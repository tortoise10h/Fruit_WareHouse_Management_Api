using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using api.Contracts.V1.Exceptions;
using api.Common.Enums;
using api.Helpers;
using E = api.Entities;
using api.IServices;
using api.Contracts.V1.ResponseModels.GoodsDeliveryNotes;

namespace api.CQRS.GoodsDeliveryNotes.Commands.UpdateGoodsDeliveryNotes
{
    public class UpdateGoodsDeliveryNotesCommand : IRequest<Result<GoodsDeliveryNoteResponse>>
    {
        public int Id { get; set; }
        public GoodsDeliveryNoteStatus Status { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
    }

    public class UpdateGoodsDeliveryNotesHandler : IRequestHandler<UpdateGoodsDeliveryNotesCommand, Result<GoodsDeliveryNoteResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGoodsDeliveryNoteServices _goodsDeliveryNoteServices;

        public UpdateGoodsDeliveryNotesHandler(DataContext context, IMapper mapper, IGoodsDeliveryNoteServices goodsDeliveryNoteServices)
        {
            _context = context;
            _mapper = mapper;
            _goodsDeliveryNoteServices = goodsDeliveryNoteServices;
        }

        public async Task<Result<GoodsDeliveryNoteResponse>> Handle(UpdateGoodsDeliveryNotesCommand request, CancellationToken cancellationToken)
        {
            var goodsDeliveryNote = await _context.GoodsDeliveryNotes
                .SingleOrDefaultAsync(x => x.Id == request.Id);
            if (goodsDeliveryNote == null)
            {
                return new Result<GoodsDeliveryNoteResponse>(
                    new NotFoundException()
                );
            }

            /** Only allow update goods delivery note when it is not Done or canceled */
            if (goodsDeliveryNote.Status == GoodsDeliveryNoteStatus.Done ||
                goodsDeliveryNote.Status == GoodsDeliveryNoteStatus.Cancelled)
            {
                throw new BadRequestException(
                    new ApiError("Phiếu xuất kho này không được phép chỉnh sửa"));
            }

            /** If status is changed then make sure it's valid */
            if (goodsDeliveryNote.Status != request.Status)
            {
                await _goodsDeliveryNoteServices.ValidateWhenUpdateStatus(goodsDeliveryNote, request.Status);
                await _goodsDeliveryNoteServices.HandleBusinessWhenStatusIsChanged(
                    _context,
                    goodsDeliveryNote,
                    request.Status);
            }

            _mapper.Map<UpdateGoodsDeliveryNotesCommand, E.GoodsDeliveryNote>(request, goodsDeliveryNote);

            _context.GoodsDeliveryNotes.Update(goodsDeliveryNote);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<GoodsDeliveryNoteResponse>(
                    _mapper.Map<GoodsDeliveryNoteResponse>(goodsDeliveryNote)
                );
            }

            return new Result<GoodsDeliveryNoteResponse>(
                new BadRequestException(
                    new ApiError("Chỉnh sửa thông tin phiếu xuất kho mua hàng thất bại, xin thử lại"))
            );
        }
    }
}