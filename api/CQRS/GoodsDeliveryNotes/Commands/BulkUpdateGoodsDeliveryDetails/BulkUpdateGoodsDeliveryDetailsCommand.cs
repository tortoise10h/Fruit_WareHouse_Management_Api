using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsDeliveryNotes;
using api.CQRS.GoodsDeliveryNotes.Commands.UpdateGoodsDeliveryDetail;
using api.Entities;
using api.Helpers;
using api.IServices;
using api.Services;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using E = api.Entities;

namespace api.CQRS.GoodsDeliveryNotes.Commands.BulkUpdateGoodsDeliveryDetail
{ 
    public class BulkUpdateGoodsDeliveryDetailsCommand : IRequest<Result<List<GoodsDeliveryDetailResponse>>>
    {
        public int GoodsDeliveryNoteId { get; set; }
        public List<UpdateGoodsDeliveryDetailsCommand> GoodsDeliveryDetails { get; set; }
    }

    public class BulkUpdateGoodsDeliveryDetailsHandler : IRequestHandler<BulkUpdateGoodsDeliveryDetailsCommand, Result<List<GoodsDeliveryDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGoodsDeliveryNoteServices _goodsDeliveryNoteServices;

        public BulkUpdateGoodsDeliveryDetailsHandler(DataContext context, IMapper mapper, IGoodsDeliveryNoteServices goodsDeliveryNoteServices)
        {
            _context = context;
            _mapper = mapper;
            _goodsDeliveryNoteServices = goodsDeliveryNoteServices;
        }

        public async Task<Result<List<GoodsDeliveryDetailResponse>>> Handle(
            BulkUpdateGoodsDeliveryDetailsCommand request,
            CancellationToken cancellationToken)
        {
            var goodsDeliveryNote = await _context.GoodsDeliveryNotes
                .SingleOrDefaultAsync(x => x.Id == request.GoodsDeliveryNoteId);

            /** Make sure update goods receiving detail in valid goods receiving note */
            if (goodsDeliveryNote == null)
            {
                return new Result<List<GoodsDeliveryDetailResponse>>(
                    new NotFoundException()
                );
            }
            if (goodsDeliveryNote.Status != GoodsDeliveryNoteStatus.New)
            {
                return new Result<List<GoodsDeliveryDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép chỉnh sửa sản phẩm trong phiếu xuất kho khi phiếu đang ở trạng thái 'Mới'"))
                    );
            }


            var orderDetails = await _context.OrderDetails
                .Where(x => x.OrderId == goodsDeliveryNote.OrderId)
                .ToListAsync();
            var goodsDeliveryDetailIds = request.GoodsDeliveryDetails
                .Select(x => x.Id)
                .ToList();
            var existedGoodsDeliveryDetails = await _context.GoodsDeliveryDetails
                .Where(x => x.GoodsDeliveryNoteId == request.GoodsDeliveryNoteId &&
                    goodsDeliveryDetailIds.Contains(x.Id))
                .ToListAsync();
            var productsInGoodsDeliveryNote = new List<ProductInGoodsDeliveryNote>();
            _mapper.Map<List<UpdateGoodsDeliveryDetailsCommand>, List<ProductInGoodsDeliveryNote>>(
                request.GoodsDeliveryDetails, productsInGoodsDeliveryNote);

            /** Because the request products do not contain productId so we need to attach
             * productId to each to prevent error missing productId when update to DB */
            foreach (var product in productsInGoodsDeliveryNote)
            {
                var matchedGoodsDeliveryDetail = existedGoodsDeliveryDetails.SingleOrDefault(
                    x => x.Id == product.Id);

                product.ProductId = matchedGoodsDeliveryDetail.ProductId;
            }

            /** Validate valid updated products */ 
            productsInGoodsDeliveryNote = _goodsDeliveryNoteServices
                .ValidateWhenUpdateProductsInGoodsDeliveryNote(
                    existedGoodsDeliveryDetails,
                    orderDetails,
                    productsInGoodsDeliveryNote);

            foreach (var p in productsInGoodsDeliveryNote)
            {
                var matchedGoodsReceivingDetail = existedGoodsDeliveryDetails
                    .SingleOrDefault(x => x.ProductId == p.ProductId);
                _mapper.Map<ProductInGoodsDeliveryNote, GoodsDeliveryDetail>(
                    p, matchedGoodsReceivingDetail);
            }

            _context.GoodsDeliveryDetails.UpdateRange(existedGoodsDeliveryDetails);
            _context.Update(goodsDeliveryNote);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<List<GoodsDeliveryDetailResponse>>(
                    _mapper.Map<List<GoodsDeliveryDetailResponse>>(existedGoodsDeliveryDetails)
                );
            }

            return new Result<List<GoodsDeliveryDetailResponse>>(
                new BadRequestException(
                    new ApiError("Chỉnh sửa sản phẩm trong phiếu xuất kho thất bại, xin thử lại"))
                );
        }
    }
}
