using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.ResponseModels.Suppliers;
using api.Entities;
using api.Helpers;
using AutoMapper;
using MediatR;

namespace api.CQRS.Suppliers.Commands.CreateSupplier
{
    public class CreateSupplierCommandHandler : IRequestHandler<CreateSupplierCommand, SupplierResponse>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public CreateSupplierCommandHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<SupplierResponse> Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = _mapper.Map<Supplier>(request);
            supplier.Status = SupplierStatus.Active;
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();
            return _mapper.Map<SupplierResponse>(supplier);
        }
    }
}