using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.Suppliers;
using api.Entities;
using api.Helpers;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.Suppliers.Commands.UpdateSupplier
{
    public class UpdateSupplierCommandHandler : IRequestHandler<UpdateSupplierCommand, SupplierResponse>
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public UpdateSupplierCommandHandler(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<SupplierResponse> Handle(UpdateSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = await _context.Suppliers.SingleOrDefaultAsync(s => s.Id == request.Id);
            if (supplier == null)
            {
                throw new NotFoundException();
            }

            _mapper.Map(request, supplier);

            _context.Suppliers.Update(supplier);
            await _context.SaveChangesAsync();

            return _mapper.Map<SupplierResponse>(supplier);
        }
    }
}