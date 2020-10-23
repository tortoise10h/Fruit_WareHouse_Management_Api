using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.ProductUnits;
using api.Helpers;
using api.Services;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using E = api.Entities;

namespace api.CQRS.ProductUnits.Commands.CreateProductUnits
{
    public class CreateProductUnitCommand : IRequest<Result<ProductUnitResponse>>
    {
        public string Name { get; set; }
        public double RatioFromDefault { get; set; }
        public int ProductId { get; set; }
    }

    public class CreateProductUnitHandler : IRequestHandler<CreateProductUnitCommand, Result<ProductUnitResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateProductUnitHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<ProductUnitResponse>> Handle(
            CreateProductUnitCommand request,
            CancellationToken cancellationToken)
        {
            /** Make sure the product of new product unit is existed */
            var product = await _context.Products
                .SingleOrDefaultAsync(
                    p => p.Id == request.ProductId);
            if (product == null)
            {
                return new Result<ProductUnitResponse>(
                    new NotFoundException()
                );
            }

            var productUnit = _mapper.Map<E.ProductUnit>(request);

            await _context.ProductUnits.AddAsync(productUnit);
            var created = await _context.SaveChangesAsync();
            if (created > 0)
            {
                return new Result<ProductUnitResponse>(
                    _mapper.Map<ProductUnitResponse>(productUnit)
                );
            }

            return new Result<ProductUnitResponse>(
                new BadRequestException(new ApiError("Tạo đơn vị tính khác cho sản phẩm thất bại, xin thử lại"))
            );
        }
    }
}
