using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsDeliveryNotes;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
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

namespace api.CQRS.GoodsDeliveryNotes.Commands.BulkDeleteGoodsDeliveryDetails
{
    public class BulkDeleteGoodsDeliveryDetailsCommand : IRequest<Result<List<GoodsDeliveryDetailResponse>>>
    {
        public int GoodsDeliveryNoteId { get; set; }
        public List<int> GoodsDeliveryDetailIds { get; set; }
    }

    public class BulkDeleteGoodsDeliveryDetailsHandler : IRequestHandler<BulkDeleteGoodsDeliveryDetailsCommand, Result<List<GoodsDeliveryDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BulkDeleteGoodsDeliveryDetailsHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<GoodsDeliveryDetailResponse>>> Handle(
            BulkDeleteGoodsDeliveryDetailsCommand request,
            CancellationToken cancellationToken)
        {
            var goodsDeliveryNote = await _context.GoodsDeliveryNotes
                .SingleOrDefaultAsync(x => x.Id == request.GoodsDeliveryNoteId);

            if (goodsDeliveryNote == null)
            {
                return new Result<List<GoodsDeliveryDetailResponse>>(
                    new NotFoundException()
                );
            }

            /** Only can delete products in goods delivery note when it is
             * New */
            if (goodsDeliveryNote.Status != GoodsDeliveryNoteStatus.New)
            {
                return new Result<List<GoodsDeliveryDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép xoá trong phiếu xuất kho khi đang ở trạng thái 'Mới'"))
                    );
            }

            /** Validate deleted list */
            // Unique list
            request.GoodsDeliveryDetailIds = request.GoodsDeliveryDetailIds
                .Distinct()
                .ToList();

            // Make sure all delete items are existed in goods delivery note
            var deletedGoodsDeliveryDetails = await _context.GoodsDeliveryDetails
                .Where(x => x.GoodsDeliveryNoteId == request.GoodsDeliveryNoteId &&
                    request.GoodsDeliveryDetailIds.Contains(x.Id))
                .ToListAsync();
            if (deletedGoodsDeliveryDetails.Count() != request.GoodsDeliveryDetailIds.Count())
            {
                return new Result<List<GoodsDeliveryDetailResponse>>(
                    new NotFoundException()
                );
            }

            // if products in goods delivery note are deleted then re-caculate total price
            // of it again by subtract all deleted products price
            goodsDeliveryNote.TotalPrice = deletedGoodsDeliveryDetails
                .Sum(x => x.TotalPrice);

            _context.GoodsDeliveryDetails.RemoveRange(deletedGoodsDeliveryDetails);

            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<List<GoodsDeliveryDetailResponse>>(
                    _mapper.Map<List<GoodsDeliveryDetailResponse>>(deletedGoodsDeliveryDetails)
                );
            }

            return new Result<List<GoodsDeliveryDetailResponse>>(
                new BadRequestException(
                    new ApiError("Xoá sản phẩm trong phiếu xuất kho thất bại, xin thử lại"))
                );
        }
    }
}
