using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.Exceptions;
using api.Helpers;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.Suppliers.Commands.RemoveProductsFromSupplier
{
    public class RemoveProductsFromSupplierCommandHandler : IRequestHandler<RemoveProductsFromSupplierCommand>
    {
        private readonly DataContext _context;

        public RemoveProductsFromSupplierCommandHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveProductsFromSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = await _context.Suppliers.SingleOrDefaultAsync(s => s.Id == request.SupplierId);
            if (supplier == null)
            {
                throw new NotFoundException();
            }

            // Remove duplicate id
            var productIds = request.ProductIds.Distinct().ToList();

            // Validate products is existed
            var supplierProducts = await _context.SupplierProducts
                .Where(sp => productIds.Contains(sp.ProductId))
                .ToListAsync();

            var supplierProductIds = supplierProducts
                .Select(sp => sp.ProductId)
                .ToList();

            List<int> productIdsNotFound = productIds
                .Except(supplierProductIds)
                .ToList();

            if (productIdsNotFound != null && productIdsNotFound.Count > 0)
            {
                string err = string.Format("Sản phẩm id {0} không tồn tại ở nhà cung cấp này", string.Join(",", productIdsNotFound));
                throw new BadRequestException(new ApiError(err));
            }

            _context.SupplierProducts.RemoveRange(supplierProducts);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}