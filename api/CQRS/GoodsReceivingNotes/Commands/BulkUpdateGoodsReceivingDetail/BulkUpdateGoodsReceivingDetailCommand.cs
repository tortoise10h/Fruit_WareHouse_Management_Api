using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
using api.CQRS.GoodsReceivingNotes.Commands.UpdateGoodsReceivingDetail;
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

namespace api.CQRS.GoodsReceivingNotes.Commands.BulkUpdateGoodsReceivingDetail
{ 
    public class BulkUpdateGoodsReceivingDetailCommand : IRequest<Result<List<GoodsReceivingDetailResponse>>>
    {
        public int GoodsReceivingNoteId { get; set; }
        public List<UpdateGoodsReceivingDetailCommand> GoodsReceivingDetails { get; set; }
    }

    public class BulkUpdateGoodsReceivingDetailHandler : IRequestHandler<BulkUpdateGoodsReceivingDetailCommand, Result<List<GoodsReceivingDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGoodsReceivingNoteServices _goodsReceivingNoteServices;

        public BulkUpdateGoodsReceivingDetailHandler(DataContext context, IMapper mapper, IGoodsReceivingNoteServices purchaseProposalFormService)
        {
            _context = context;
            _mapper = mapper;
            _goodsReceivingNoteServices = purchaseProposalFormService;
        }

        public async Task<Result<List<GoodsReceivingDetailResponse>>> Handle(
            BulkUpdateGoodsReceivingDetailCommand request,
            CancellationToken cancellationToken)
        {
            var goodsReceivingNote = await _context.GoodsReceivingNotes
                .SingleOrDefaultAsync(x => x.Id == request.GoodsReceivingNoteId);

            /** Make sure update goods receiving detail in valid goods receiving note */
            if (goodsReceivingNote == null)
            {
                return new Result<List<GoodsReceivingDetailResponse>>(
                    new NotFoundException()
                );
            }
            if (goodsReceivingNote.Status != GoodsReceivingNoteStatus.New)
            {
                return new Result<List<GoodsReceivingDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép chỉnh sửa sản phẩm trong phiếu nhập kho khi phiếu đang ở trạng thái 'Mới'"))
                    );
            }


            var purchaseProposalDetails = await _context.PurchaseProposalDetails
                .Where(x => x.PurchaseProposalFormId == goodsReceivingNote.PurchaseProposalFormId)
                .ToListAsync();
            var goodsReceivingDetailIds = request.GoodsReceivingDetails
                .Select(x => x.Id)
                .ToList();
            var existedGoodsReceivingDetails = await _context.GoodsReceivingDetails
                .Where(x => x.GoodsReceivingNoteId == request.GoodsReceivingNoteId &&
                    goodsReceivingDetailIds.Contains(x.Id))
                .ToListAsync();
            var productsInGoodsReceivingNote = new List<ProductInGoodsReceivingNote>();
            _mapper.Map<List<UpdateGoodsReceivingDetailCommand>, List<ProductInGoodsReceivingNote>>(
                request.GoodsReceivingDetails, productsInGoodsReceivingNote);

            if (existedGoodsReceivingDetails == null || existedGoodsReceivingDetails.Count == 0)
            {
                return new Result<List<GoodsReceivingDetailResponse>>(
                    new NotFoundException()
                );
            }

            foreach (var grd in existedGoodsReceivingDetails)
            {
                var matchedProductInGoodsReceivingNote = productsInGoodsReceivingNote
                    .SingleOrDefault(x => x.Id == grd.Id);
                matchedProductInGoodsReceivingNote.ProductId = grd.ProductId;
            }


            /** Validate valid updated products */ 
            productsInGoodsReceivingNote = _goodsReceivingNoteServices
                .ValidateWhenUpdateProductsInGoodsReceivingNote(
                    existedGoodsReceivingDetails,
                    purchaseProposalDetails,
                    productsInGoodsReceivingNote);

            /** Update price of goods receiving detail and goods receiving note */
            productsInGoodsReceivingNote = _goodsReceivingNoteServices.CalculatePriceOfProducsInGoodsReceivingNote(
                productsInGoodsReceivingNote);

            // Replace old total price with new price after update goods receiving details
            goodsReceivingNote.TotalPrice = goodsReceivingNote.TotalPrice - existedGoodsReceivingDetails
                .Sum(x => x.TotalPrice);
            goodsReceivingNote.TotalPrice = goodsReceivingNote.TotalPrice + productsInGoodsReceivingNote
                .Sum(x => x.TotalPrice);

            foreach (var p in productsInGoodsReceivingNote)
            {
                var matchedGoodsReceivingDetail = existedGoodsReceivingDetails
                    .SingleOrDefault(x => x.ProductId == p.ProductId);
                _mapper.Map<ProductInGoodsReceivingNote, GoodsReceivingDetail>(
                    p, matchedGoodsReceivingDetail);
            }

            _context.GoodsReceivingDetails.UpdateRange(existedGoodsReceivingDetails);
            _context.Update(goodsReceivingNote);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<List<GoodsReceivingDetailResponse>>(
                    _mapper.Map<List<GoodsReceivingDetailResponse>>(existedGoodsReceivingDetails)
                );
            }

            return new Result<List<GoodsReceivingDetailResponse>>(
                new BadRequestException(
                    new ApiError("Chỉnh sửa sản phẩm trong phiếu nhập kho thất bại, xin thử lại"))
                );
        }
    }
}
