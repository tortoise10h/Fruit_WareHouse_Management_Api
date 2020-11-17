using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.Suppliers;
using api.Helpers;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.Suppliers.Queries.GetById
{
    public class GetSupplierByIdQueryHandler : IRequestHandler<GetSupplierByIdQuery, SupplierResponse>
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public GetSupplierByIdQueryHandler(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<SupplierResponse> Handle(GetSupplierByIdQuery query, CancellationToken cancellationToken)
        {
            var supplier = await _context.Suppliers
               .Include(s => s.SupplierProducts)
                .ThenInclude(sp => sp.Product)
               .SingleOrDefaultAsync(s => s.Id == query.Id);

            if (supplier == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<SupplierResponse>(supplier);
        }
    }
}