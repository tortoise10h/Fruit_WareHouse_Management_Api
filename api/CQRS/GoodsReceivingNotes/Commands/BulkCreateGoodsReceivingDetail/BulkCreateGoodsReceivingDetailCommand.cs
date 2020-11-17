using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
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

namespace api.CQRS.GoodsReceivingNotes.Commands.BulkCreateGoodsReceivingDetails
{ 
    public class BulkCreateGoodsReceivingDetailCommand : IRequest<Result<List<GoodsReceivingDetailResponse>>>
    {
        public int GoodsReceivingNoteId { get; set; }
        public List<CreateGoodsReceivingDetailCommand> GoodsReceivingDetails { get; set; }
    }

    public class BulkCreateGoodsReceivingDetailHandler : IRequestHandler<BulkCreateGoodsReceivingDetailCommand, Result<List<GoodsReceivingDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGoodsReceivingNoteServices _goodsReceivingNoteServices;

        public BulkCreateGoodsReceivingDetailHandler(DataContext context, IMapper mapper, IGoodsReceivingNoteServices goodsReceivingNoteServices)
        {
            _context = context;
            _mapper = mapper;
            _goodsReceivingNoteServices = goodsReceivingNoteServices;
        }

        public async Task<Result<List<GoodsReceivingDetailResponse>>> Handle(
            BulkCreateGoodsReceivingDetailCommand request,
            CancellationToken cancellationToken)
        {
            var goodsReceivingNote = await _context.GoodsReceivingNotes
                .SingleOrDefaultAsync(x => x.Id == request.GoodsReceivingNoteId);

            /** Make sure add product to valid goods receiving note */
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
                        new ApiError("Chỉ được phép thêm sản phẩm vào phiếu nhập kho khi đang ở trạng thái 'Mới'"))
                    );
            }

            /** Validate new product comparing to purchase proposal form */
            var purchaseProposalDetails = await _context.PurchaseProposalDetails
                .Where(x => x.PurchaseProposalFormId == goodsReceivingNote.PurchaseProposalFormId)
                .ToListAsync();

            var productsInGoodsReceivingNote = new List<ProductInGoodsReceivingNote>();
            _mapper.Map<List<CreateGoodsReceivingDetailCommand>, List<ProductInGoodsReceivingNote>>(
                request.GoodsReceivingDetails, productsInGoodsReceivingNote);

            productsInGoodsReceivingNote = await _goodsReceivingNoteServices
                .ValidateWhenAddNewProductToExistedGoodsReceivingNote(
                    goodsReceivingNote.Id,
                    purchaseProposalDetails,
                    productsInGoodsReceivingNote);

            if (goodsReceivingNote.SupplierId != null)
            {
                // if goods receiving note belong to supplier => all new products
                // must be belonged to that supplier too
                await _goodsReceivingNoteServices.MakeSureNewProductMustBelongToSupplier(
                    goodsReceivingNote.SupplierId.GetValueOrDefault(),
                    productsInGoodsReceivingNote);
            }

            _mapper.Map<List<ProductInGoodsReceivingNote>, List<CreateGoodsReceivingDetailCommand>>(
                productsInGoodsReceivingNote,
                request.GoodsReceivingDetails);

            /** Prepare info for entities to save */
            List<GoodsReceivingDetail> goodsReceivingDetailEntities = _mapper.Map<List<GoodsReceivingDetail>>(
                request.GoodsReceivingDetails
                );

            foreach(var grd in goodsReceivingDetailEntities)
            {
                grd.GoodsReceivingNoteId = request.GoodsReceivingNoteId;
            }

            // Calculate total price of each goods receiving detail item
            goodsReceivingDetailEntities = _goodsReceivingNoteServices.CalculatePriceOfProducsInGoodsReceivingNote(
                goodsReceivingDetailEntities);

            // After has total price of each goods receiving item then
            // calculate total price of this goods receiving note
            goodsReceivingNote.TotalPrice = goodsReceivingNote.TotalPrice + goodsReceivingDetailEntities
                .Sum(x => x.TotalPrice); 

            await _context.GoodsReceivingDetails.AddRangeAsync(goodsReceivingDetailEntities);
            var created = await _context.SaveChangesAsync(); 

            if (created > 0)
            {
                return new Result<List<GoodsReceivingDetailResponse>>(
                    _mapper.Map<List<GoodsReceivingDetailResponse>>(goodsReceivingDetailEntities)
                );
            }

            return new Result<List<GoodsReceivingDetailResponse>>(
                new BadRequestException(
                    new ApiError("Thêm sản phẩm vào phiếu nhập kho thất bại, xin thử lại"))
                );
        }
    }
}
