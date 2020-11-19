using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsDeliveryNotes;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.CQRS.GoodsDeliveryNotes.Commands.CreateGoodsDeliveryDetails;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.Entities;
using api.Helpers;
using api.IServices;
using api.Services;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using E = api.Entities;

namespace api.CQRS.GoodsDeliveryNotes.Commands.BulkCreateGoodsDeliveryDetails
{ 
    public class BulkCreateGoodsDeliveryDetailsCommand : IRequest<Result<List<GoodsDeliveryDetailResponse>>>
    {
        public int GoodsDeliveryNoteId { get; set; }
        public List<CreateGoodsDeliveryDetailsCommand> GoodsDeliveryDetails { get; set; }
    }

    public class BulkCreateGoodsDeliveryDetailsHandler : IRequestHandler<BulkCreateGoodsDeliveryDetailsCommand, Result<List<GoodsDeliveryDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGoodsDeliveryNoteServices _goodsDeliveryNoteServices;

        public BulkCreateGoodsDeliveryDetailsHandler(DataContext context, IMapper mapper, IGoodsDeliveryNoteServices goodsDeliveryNoteService)
        {
            _context = context;
            _mapper = mapper;
            _goodsDeliveryNoteServices = goodsDeliveryNoteService;
        }

        public async Task<Result<List<GoodsDeliveryDetailResponse>>> Handle(
            BulkCreateGoodsDeliveryDetailsCommand request,
            CancellationToken cancellationToken)
        {
            var goodsDeliveryNote = await _context.GoodsDeliveryNotes
                .SingleOrDefaultAsync(x => x.Id == request.GoodsDeliveryNoteId);

            /** Make sure add product to valid goods delivery note */
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
                        new ApiError("Chỉ được phép thêm sản phẩm vào phiếu xuất kho khi đang ở trạng thái 'Mới'"))
                    );
            }

            /** Make sure new products valid */
            var orderDetails = await _context.OrderDetails
                .Where(x => x.OrderId == goodsDeliveryNote.OrderId)
                .ToListAsync();

            var productsInGoodsDeliveryNote = new List<ProductInGoodsDeliveryNote>();
            _mapper.Map<List<CreateGoodsDeliveryDetailsCommand>, List<ProductInGoodsDeliveryNote>>(
                request.GoodsDeliveryDetails, productsInGoodsDeliveryNote);

            productsInGoodsDeliveryNote = await _goodsDeliveryNoteServices
                .ValidateWhenAddNewProductToExistedGoodsDeliveryNote(
                    goodsDeliveryNote.Id,
                    orderDetails,
                    productsInGoodsDeliveryNote);

            /** Prepare info for entities to save */
            List<GoodsDeliveryDetail> goodsDeliveryDetailEntties = _mapper.Map<List<GoodsDeliveryDetail>>(
                productsInGoodsDeliveryNote
                );

            foreach(var gdd in goodsDeliveryDetailEntties)
            {
                gdd.GoodsDeliveryNoteId = request.GoodsDeliveryNoteId;
            }

            await _context.GoodsDeliveryDetails.AddRangeAsync(goodsDeliveryDetailEntties);
            var created = await _context.SaveChangesAsync(); 

            if (created > 0)
            {
                return new Result<List<GoodsDeliveryDetailResponse>>(
                    _mapper.Map<List<GoodsDeliveryDetailResponse>>(goodsDeliveryDetailEntties)
                );
            }

            return new Result<List<GoodsDeliveryDetailResponse>>(
                new BadRequestException(
                    new ApiError("Thêm sản phẩm vào phiếu xuất kho thất bại, xin thử lại"))
                );
        }
    }
}
