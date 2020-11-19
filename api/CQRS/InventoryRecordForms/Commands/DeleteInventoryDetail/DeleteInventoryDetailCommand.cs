using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.InventoryRecordForms;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.InventoryRecordForms.Commands.DeleteInventoryDetail
{
    public class DeleteInventoryDetailCommand : IRequest<Result<List<InventoryRecordDetailResponse>>>
    {
        public int InventoryRecordFormId { get; set; }
        public List<int> InventoryDetailIds { get; set; }
    }

    public class DeleteInventoryDetailHandler : IRequestHandler<DeleteInventoryDetailCommand, Result<List<InventoryRecordDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DeleteInventoryDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<InventoryRecordDetailResponse>>> Handle(DeleteInventoryDetailCommand request, CancellationToken cancellationToken)
        {
            var inventoryRecordForm = await _context.InventoryRecordForms.SingleOrDefaultAsync(
                irf => irf.Id == request.InventoryRecordFormId
            );

            if (inventoryRecordForm == null)
            {
                return new Result<List<InventoryRecordDetailResponse>>(
                    new NotFoundException()
                );
            }

            /** Only can remove products from inventory record form when it is
             * New */
            if (inventoryRecordForm.Status != InventoryRecordFormStatus.New)
            {
                return new Result<List<InventoryRecordDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép xoá sản phẩm khỏi phiếu kiểm kho khi đang ở trạng thái 'Mới'"))
                    );
            }

            var inventoryDetails = request.InventoryDetailIds
                .ToList();

            // Validate inventory record detail is unique
            var DistinctInventoryDetails = request.InventoryDetailIds
                .Distinct()
                .ToList();

            if (inventoryDetails.Count() != DistinctInventoryDetails.Count())
            {
                return new Result<List<InventoryRecordDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Id của phiếu chi tiết kiểm kho phải là duy nhất")
                    )
                );
            }

            // Validate inventory record detail exist
            var inventoryRecordDetails = await _context.InventoryRecordDetails
                .Where(p => p.InventoryRecordId == request.InventoryRecordFormId &&
                    inventoryDetails.Contains(p.Id))
                .ToListAsync();

            if (DistinctInventoryDetails.Count() != inventoryRecordDetails.Count())
            {
                return new Result<List<InventoryRecordDetailResponse>>(
                    new NotFoundException()
                );
            }

            _context.InventoryRecordDetails.RemoveRange(inventoryRecordDetails);
            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<List<InventoryRecordDetailResponse>>(
                    _mapper.Map<List<InventoryRecordDetailResponse>>(inventoryRecordDetails)
                );
            }

            return new Result<List<InventoryRecordDetailResponse>>(
                new BadRequestException(
                    new ApiError("Xoá sản phẩm trong phiếu đề nghị xảy ra lỗi, xin thử lại"))
            );
        }
    }
}