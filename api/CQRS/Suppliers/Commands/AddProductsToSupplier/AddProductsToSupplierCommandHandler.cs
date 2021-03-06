using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.Exceptions;
using api.Entities;
using api.Helpers;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.Suppliers.Commands.AddProductsToSupplier
{
    public class AddProductsToSupplierCommandHandler : IRequestHandler<AddProductsToSupplierCommand>
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public AddProductsToSupplierCommandHandler(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Unit> Handle(AddProductsToSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = await _context.Suppliers.SingleOrDefaultAsync(s => s.Id == request.SupplierId);
            if (supplier == null)
            {
                throw new NotFoundException();
            }

            // Unique product id in the list
            var productDTOs = request.Products
                .GroupBy(x => x.ProductId)
                .Select(x => x.First())
                .ToList();

            var productIds = productDTOs
                .Select(x => x.ProductId)
                .ToList();

            // Validate products is existed
            var products = await _context.Products
                .Where(p => productIds.Contains(p.Id))
                .ToListAsync();

            if (productIds.Count() != products.Count())
            {
                throw new NotFoundException();
            }

            // Handle add existed supplier product
            var existedSupplierProduct = await _context.SupplierProducts
                .Where(sp => sp.SupplierId == request.SupplierId)
                .Select(sp => sp.ProductId)
                .ToListAsync();

            List<int> duplicates = existedSupplierProduct.Intersect(productIds).ToList();
            if (duplicates != null && duplicates.Count > 0)
            {
                string err = string.Format("Sản phẩm id {0} đã được thêm vào nhà cung cấp từ trước", string.Join(",", duplicates));
                throw new BadRequestException(new ApiError(err));
            }

            var supplierProducts = _mapper.Map<List<SupplierProduct>>(request.Products);
            foreach (var supplierProduct in supplierProducts)
            {
                supplierProduct.SupplierId = request.SupplierId;
            }

            await _context.SupplierProducts.AddRangeAsync(supplierProducts);

            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}