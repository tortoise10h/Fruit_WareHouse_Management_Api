using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsDeliveryNotes;
using api.CQRS.GoodsDeliveryNotes.Commands.CreateGoodsDeliveryDetails;
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

namespace api.CQRS.GoodsDeliveryNotes.Commands.CreateGoodsDeliveryNotes
{
    public class CreateGoodsDeliveryNotesCommand : IRequest<Result<GoodsDeliveryNoteResponse>>
    {
        public string Description { get; set; }
        public int OrderId { get; set; }
        public List<CreateGoodsDeliveryDetailsCommand> GoodsDeliveryDetails { get; set; }
    }

    public class CreateGoodsDeliveryNotesHandler : IRequestHandler<CreateGoodsDeliveryNotesCommand, Result<GoodsDeliveryNoteResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGoodsDeliveryNoteServices _goodsDeliveryNoteServices;

        public CreateGoodsDeliveryNotesHandler(DataContext context, IMapper mapper, IGoodsDeliveryNoteServices goodsDeliveryNoteServices)
        {
            _context = context;
            _mapper = mapper;
            _goodsDeliveryNoteServices = goodsDeliveryNoteServices;
        }

        public async Task<Result<GoodsDeliveryNoteResponse>> Handle(
            CreateGoodsDeliveryNotesCommand request,
            CancellationToken cancellationToken)
        {
            var order = await _context.Orders
                .Include(x => x.OrderDetails)
                .SingleOrDefaultAsync(x => x.Id == request.OrderId);

            /** Make sure we are creating goods delivery note for a valid order */
            if (order == null)
            {
                throw new NotFoundException();
            }
            if (order.Status != OrderStatus.Processing)
            {
                throw new BadRequestException(new ApiError("Chỉ được xuất kho cho đơn hàng đang 'được xử lý'"));
            }

            var orderDetails = order.OrderDetails
                .ToList();
            var productsInGoodsDeliveryNote = new List<ProductInGoodsDeliveryNote>();
            _mapper.Map<List<CreateGoodsDeliveryDetailsCommand>, List<ProductInGoodsDeliveryNote>>(
                request.GoodsDeliveryDetails, productsInGoodsDeliveryNote);

            /** Make sure all product in a new goods delivery note valid */
            productsInGoodsDeliveryNote = await _goodsDeliveryNoteServices.MakeSureProductsOfNewGoodsDeliveryNoteValid(
                productsInGoodsDeliveryNote, orderDetails);

            /** Prepare entity to save to DB */
            _mapper.Map<List<ProductInGoodsDeliveryNote>, List<CreateGoodsDeliveryDetailsCommand>>(
                productsInGoodsDeliveryNote, request.GoodsDeliveryDetails);
            var goodsDeliveryNoteEntity = _mapper.Map<GoodsDeliveryNote>(
                request);

            goodsDeliveryNoteEntity.Status = GoodsDeliveryNoteStatus.New;

            await _context.AddAsync(goodsDeliveryNoteEntity);
            var created = await _context.SaveChangesAsync();
            if (created > 0)
            {
                return new Result<GoodsDeliveryNoteResponse>(
                    _mapper.Map<GoodsDeliveryNoteResponse>(goodsDeliveryNoteEntity)
                );
            }
            return new Result<GoodsDeliveryNoteResponse>(
                _mapper.Map<GoodsDeliveryNoteResponse>(
                    new BadRequestException(new ApiError("Tạo phiếu xuất kho xảy ra lỗi, xin thử lại"))
                    )
            );
        }
    }
}
