using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.Suppliers;
using api.Helpers;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.Suppliers.Commands.DeleteSupplier
{
    public class DeleteSupplierCommandHandler : IRequestHandler<DeleteSupplierCommand, SupplierResponse>
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public DeleteSupplierCommandHandler(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<SupplierResponse> Handle(DeleteSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = await _context.Suppliers.SingleOrDefaultAsync(pc => pc.Id == request.Id);

            if (supplier == null)
            {
                throw new NotFoundException();
            }

            var productOfSupplier = await _context.SupplierProducts.FirstOrDefaultAsync(sp => sp.SupplierId == request.Id);
            if (productOfSupplier != null)
            {
                throw new BadRequestException(new ApiError("Chỉ có thể xóa nhà cung cấp không có sản phẩm"));
            }

            _context.Suppliers.Remove(supplier);
            await _context.SaveChangesAsync();
            return _mapper.Map<SupplierResponse>(supplier);
        }
    }
}