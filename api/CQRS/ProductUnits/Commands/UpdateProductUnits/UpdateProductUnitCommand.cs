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
using api.Contracts.V1.ResponseModels.ProductUnits;

namespace api.CQRS.ProductUnits.Commands.UpdateProductUnits
{
    public class UpdateProductUnitCommand : IRequest<Result<ProductUnitResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double RatioFromDefault { get; set; }
    }

    public class UpdateProductUnitHandler : IRequestHandler<UpdateProductUnitCommand, Result<ProductUnitResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateProductUnitHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<ProductUnitResponse>> Handle(UpdateProductUnitCommand request, CancellationToken cancellationToken)
        {
            var productUnit = await _context.ProductUnits
                .SingleOrDefaultAsync(
                    pu => pu.Id == request.Id
                );
            if (productUnit == null)
            {
                return new Result<ProductUnitResponse>(
                    new NotFoundException()
                );
            }

            _mapper.Map<UpdateProductUnitCommand, E.ProductUnit>(request, productUnit);

            _context.ProductUnits.Update(productUnit);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<ProductUnitResponse>(
                    _mapper.Map<ProductUnitResponse>(productUnit)
                );
            }

            return new Result<ProductUnitResponse>(
                new BadRequestException(
                    new ApiError("Chỉnh sửa đơn vị tính thất bại, xin thử lại"))
            );
        }
    }
}