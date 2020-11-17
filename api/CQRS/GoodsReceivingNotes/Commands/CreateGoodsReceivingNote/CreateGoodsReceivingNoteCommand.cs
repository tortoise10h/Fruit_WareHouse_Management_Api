using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using api.Entities;
using api.Helpers;
using api.IServices; 
using AutoMapper;
using LanguageExt.Common;
using LanguageExt.Pipes;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using E = api.Entities;

namespace api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingNote
{
    public class CreateGoodsReceivingNoteCommand : IRequest<Result<GoodsReceivingNoteResponse>>
    {
        public string SupplierName { get; set; }
        public int? SupplierId { get; set; }
        public string Description { get; set; }
        public int PurchaseProposalFormId { get; set; }
        public List<CreateGoodsReceivingDetailCommand> GoodsReceivingDetails { get; set; }
    }

    public class CreateGoodsReceivingNoteHandler : IRequestHandler<CreateGoodsReceivingNoteCommand, Result<GoodsReceivingNoteResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGoodsReceivingNoteServices _goodsReceivingNoteServices;

        public CreateGoodsReceivingNoteHandler(DataContext context, IMapper mapper, IGoodsReceivingNoteServices goodsReceivingNoteServices)
        {
            _context = context;
            _mapper = mapper;
            _goodsReceivingNoteServices = goodsReceivingNoteServices;
        }

        public async Task<Result<GoodsReceivingNoteResponse>> Handle(
            CreateGoodsReceivingNoteCommand request,
            CancellationToken cancellationToken)
        {
            var purchaseProposalForm = await _context.PurchaseProposalForms
                .Include(x => x.PurchaseProposalDetails)
                .SingleOrDefaultAsync(x => x.Id == request.PurchaseProposalFormId);

            /** Make sure purchase proposal form valid */
            if (purchaseProposalForm == null)
            {
                throw new NotFoundException();
            }
            if (purchaseProposalForm.Status != PurchaseProposalFormStatus.Processing)
            {
                throw new BadRequestException(new ApiError("Chỉ được nhập kho cho đề nghị mua hàng đang 'được xử lý'"));
            }

            var purchaseProposalDetails = purchaseProposalForm.PurchaseProposalDetails
                .ToList();
            var productsInGoodsReceivingNote = new List<ProductInGoodsReceivingNote>();


            /** Make sure all product in goods receiving note valid */
            _mapper.Map<List<CreateGoodsReceivingDetailCommand>, List<ProductInGoodsReceivingNote>>(
                request.GoodsReceivingDetails, productsInGoodsReceivingNote);

            productsInGoodsReceivingNote = _goodsReceivingNoteServices.MakeSureProductsOfNewGoodsReceivingNoteSastifyProposal(
                productsInGoodsReceivingNote, purchaseProposalDetails);

            if (request.SupplierId != null)
            {
                // This mean we do import from a specific supplier 
                var supplier = await _context.Suppliers
                    .SingleOrDefaultAsync(x => x.Id == request.SupplierId);
                if (supplier == null)
                {
                    throw new NotFoundException();
                }

                await _goodsReceivingNoteServices.MakeSureNewProductMustBelongToSupplier(
                    supplier.Id,
                    productsInGoodsReceivingNote);

                request.SupplierName = supplier.Name;
            }


            /** Prepare entity to save to DB */
            // Map list valid product back to command to map to entity
            _mapper.Map<List<ProductInGoodsReceivingNote>, List<CreateGoodsReceivingDetailCommand>>(
                productsInGoodsReceivingNote, request.GoodsReceivingDetails);

            var goodsReceivingNoteEntity = _mapper.Map<GoodsReceivingNote>(
                request);
            goodsReceivingNoteEntity.Status = GoodsReceivingNoteStatus.New;

            // Calculate total price of each goods receiving detail item
            goodsReceivingNoteEntity.GoodsReceivingDetails = _goodsReceivingNoteServices.CalculatePriceOfProducsInGoodsReceivingNote(
                goodsReceivingNoteEntity.GoodsReceivingDetails.ToList());

            // After has total price of each goods receiving item then
            // calculate total price of this goods receiving note
            goodsReceivingNoteEntity.TotalPrice = goodsReceivingNoteEntity.GoodsReceivingDetails
                .Sum(x => x.TotalPrice); 

            await _context.GoodsReceivingNotes.AddAsync(goodsReceivingNoteEntity);
            var created = await _context.SaveChangesAsync();
            if (created > 0)
            {
                return new Result<GoodsReceivingNoteResponse>(
                    _mapper.Map<GoodsReceivingNoteResponse>(goodsReceivingNoteEntity)
                );
            }
            return new Result<GoodsReceivingNoteResponse>(
                _mapper.Map<GoodsReceivingNoteResponse>(
                    new BadRequestException(new ApiError("Tạo phiếu nhập kho xảy ra lỗi, xin thử lại"))
                    )
            );
        }
    }
}
