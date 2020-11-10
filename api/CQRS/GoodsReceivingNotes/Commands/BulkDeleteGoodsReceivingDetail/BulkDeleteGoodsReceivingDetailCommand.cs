using api.Common.Enums;
using api.Contracts.V1.Exceptions;
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

namespace api.CQRS.GoodsReceivingNotes.Commands.BulkDeleteGoodsReceivingDetail
{ 
    public class BulkDeleteGoodsReceivingDetailCommand : IRequest<Result<List<GoodsReceivingDetailResponse>>>
    {
        public int GoodsReceivingNoteId { get; set; }
        public List<int> GoodsReceivingDetailIds { get; set; }
    }

    public class BulkDeleteGoodsReceivingDetailHandler : IRequestHandler<BulkDeleteGoodsReceivingDetailCommand, Result<List<GoodsReceivingDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGoodsReceivingNoteServices _goodsReceivingNoteServices;

        public BulkDeleteGoodsReceivingDetailHandler(DataContext context, IMapper mapper, IGoodsReceivingNoteServices goodsReceivingNoteServices)
        {
            _context = context;
            _mapper = mapper;
            _goodsReceivingNoteServices = goodsReceivingNoteServices;
        }

        public async Task<Result<List<GoodsReceivingDetailResponse>>> Handle(
            BulkDeleteGoodsReceivingDetailCommand request,
            CancellationToken cancellationToken)
        {
            var goodsReceivingNote = await _context.GoodsReceivingNotes
                .SingleOrDefaultAsync(x => x.Id == request.GoodsReceivingNoteId);

            if (goodsReceivingNote == null)
            {
                return new Result<List<GoodsReceivingDetailResponse>>(
                    new NotFoundException()
                );
            }

            /** Only can delete products to purchase proposal form when it is
             * New or Processing */
            if (goodsReceivingNote.Status != GoodsReceivingNoteStatus.New)
            {
                return new Result<List<GoodsReceivingDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép xoá trong phiếu nhập kho khi đang ở trạng thái 'Mới'"))
                    );
            }

            /** Validate deleted list */
            // Unique list
            request.GoodsReceivingDetailIds = request.GoodsReceivingDetailIds
                .Distinct()
                .ToList();

            // Make sure all delete items are existed in goods receiving note
            var deletedGoodsReceivingDetails = await _context.GoodsReceivingDetails
                .Where(x => x.GoodsReceivingNoteId == request.GoodsReceivingNoteId &&
                    request.GoodsReceivingDetailIds.Contains(x.Id))
                .ToListAsync();
            if (deletedGoodsReceivingDetails.Count() != request.GoodsReceivingDetailIds.Count())
            {
                return new Result<List<GoodsReceivingDetailResponse>>(
                    new NotFoundException()
                );
            }

            /** Update price of goods receiving note after remove goods receiving details */
            goodsReceivingNote.TotalPrice -= deletedGoodsReceivingDetails
                .Sum(x => x.TotalPrice);

            _context.GoodsReceivingDetails.RemoveRange(deletedGoodsReceivingDetails);
            _context.GoodsReceivingNotes.Update(goodsReceivingNote);

            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<List<GoodsReceivingDetailResponse>>(
                    _mapper.Map<List<GoodsReceivingDetailResponse>>(deletedGoodsReceivingDetails)
                );
            }

            return new Result<List<GoodsReceivingDetailResponse>>(
                new BadRequestException(
                    new ApiError("Xoá sản phẩm trong phiếu nhập kho thất bại, xin thử lại"))
                );
        }
    }
}
