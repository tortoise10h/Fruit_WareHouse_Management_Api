using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.ProductUnits;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace api.CQRS.ProductUnits.Commands.DeleteProductUnits
{
    public class DeleteProductUnitCommand : IRequest<Result<ProductUnitResponse>>
    {
        public DeleteProductUnitCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }

    public class DeleteProductUnitHandler : IRequestHandler<DeleteProductUnitCommand, Result<ProductUnitResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DeleteProductUnitHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<ProductUnitResponse>> Handle(DeleteProductUnitCommand request, CancellationToken cancellationToken)
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

            _context.ProductUnits.Remove(productUnit);
            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<ProductUnitResponse>(
                    _mapper.Map<ProductUnitResponse>(productUnit)
                );
            }

            return new Result<ProductUnitResponse>(
                new BadRequestException(
                    new ApiError("Xoá đơn vị tính thất bại, xin thử lại"))
            );
        }
    }
}
