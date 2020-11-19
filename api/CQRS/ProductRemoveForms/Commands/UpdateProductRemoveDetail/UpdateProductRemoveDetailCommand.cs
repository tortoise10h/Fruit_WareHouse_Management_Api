using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.ProductRemoveForms;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.ProductRemoveForms.Commands.UpdateProductRemoveDetail
{
    public class UpdateProductRemoveDetailCommand : IRequest<Result<List<ProductRemoveDetailResponse>>>
    {
        public int ProductRemoveFormId { get; set; }
        public List<UpdateProductInProductRemoveDetail> ProductRemoveDetails { get; set; }
    }

    public class UpdateProductRemoveDetailHandler : IRequestHandler<UpdateProductRemoveDetailCommand, Result<List<ProductRemoveDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateProductRemoveDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<ProductRemoveDetailResponse>>> Handle(UpdateProductRemoveDetailCommand request, CancellationToken cancellationToken)
        {
            var productRemoveForm = await _context.ProductRemoveForms.SingleOrDefaultAsync(
                prf => prf.Id == request.ProductRemoveFormId
            );

            if (productRemoveForm == null)
            {
                return new Result<List<ProductRemoveDetailResponse>>(
                    new NotFoundException()
                );
            }

            /** Only can add new products to product remove for when it is
             * New */
            if (productRemoveForm.Status != ProductRemoveFormStatus.New)
            {
                return new Result<List<ProductRemoveDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép thêm sản phẩm vào phiếu huỷ sản phẩm khi đang ở trạng thái 'Mới'"))
                    );
            }

            var prds = request.ProductRemoveDetails
                .Select(p => p.Id)
                .ToList();

            // Validate product remove detail is unique
            var distinctProductRemoveDetails = request.ProductRemoveDetails
                .Select(p => p.Id)
                .Distinct()
                .ToList();

            if (prds.Count() != distinctProductRemoveDetails.Count())
            {
                return new Result<List<ProductRemoveDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Id của phiếu huỷ sản phẩm phải là duy nhất")
                    )
                );
            }

            // Validate product remove detail exist
            var productRemoveDetails = await _context.ProductRemoveDetails
                .Where(prd => prd.ProductRemoveFormId == request.ProductRemoveFormId &&
                prds.Contains(prd.Id))
                .ToListAsync();

            if (distinctProductRemoveDetails.Count() != productRemoveDetails.Count())
            {
                return new Result<List<ProductRemoveDetailResponse>>(
                    new NotFoundException()
                );
            }

            foreach (var prd in productRemoveDetails)
            {
                var detail = request.ProductRemoveDetails
                    .Where(x => x.Id == prd.Id)
                    .FirstOrDefault();

                prd.RemovedQuantity = detail.RemovedQuantity;
            }

            _context.ProductRemoveDetails.UpdateRange(productRemoveDetails);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<List<ProductRemoveDetailResponse>>(
                    _mapper.Map<List<ProductRemoveDetailResponse>>(productRemoveDetails)
                );
            }

            return new Result<List<ProductRemoveDetailResponse>>(
                new BadRequestException(
                    new ApiError("Cập nhật sản phẩm trong phiếu huỷ sản phẩm lỗi, xin thử lại"))
            );
        }
    }
}