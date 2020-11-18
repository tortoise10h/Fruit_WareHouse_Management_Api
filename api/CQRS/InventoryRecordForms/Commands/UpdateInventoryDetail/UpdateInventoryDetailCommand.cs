using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.InventoryRecordForms;
using api.Entities;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.InventoryRecordForms.Commands.UpdateInventoryDetail
{
    public class UpdateInventoryDetailCommand : IRequest<Result<List<InventoryRecordDetailResponse>>>
    {
        public int InventoryRecordFormId { get; set; }
        public List<UpdateProductInInventoryRecordDetail> InventoryRecordDetails { get; set; }
    }

    public class UpdateInventoryDetailHandler : IRequestHandler<UpdateInventoryDetailCommand, Result<List<InventoryRecordDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateInventoryDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<InventoryRecordDetailResponse>>> Handle(UpdateInventoryDetailCommand request, CancellationToken cancellationToken)
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

            /** Only can add new products to inventory record form when it is
             * New */
            if (inventoryRecordForm.Status != InventoryRecordFormStatus.New)
            {
                return new Result<List<InventoryRecordDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép thêm sản phẩm vào phiếu kiểm kho khi đang ở trạng thái 'Mới'"))
                    );
            }

            var inventoryDetails = request.InventoryRecordDetails
                .Select(p => p.Id)
                .ToList();

            // Validate inventory record detail is unique
            var DistinctInventoryDetails = request.InventoryRecordDetails
                .Select(p => p.Id)
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

            foreach (var ird in inventoryRecordDetails)
            {
                var inventoryRecordDetail = request.InventoryRecordDetails
                    .Where(x => x.Id == ird.Id)
                    .FirstOrDefault();

                ird.ActualQuantity = inventoryRecordDetail.ActualQuantity;
            }

            _context.InventoryRecordDetails.UpdateRange(inventoryRecordDetails);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<List<InventoryRecordDetailResponse>>(
                    _mapper.Map<List<InventoryRecordDetailResponse>>(inventoryRecordDetails)
                );
            }

            return new Result<List<InventoryRecordDetailResponse>>(
                new BadRequestException(
                    new ApiError("Cập nhật sản phẩm trong phiếu chi tiết kiểm kho lỗi, xin thử lại"))
            );
        }
    }
}