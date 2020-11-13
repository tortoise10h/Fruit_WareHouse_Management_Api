using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.Products;
using api.Entities;
using api.Helpers;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.Suppliers.Queries.GetAllSupplierProducts
{
    public class GetAllSupplierProductsQueryHandler : IRequestHandler<GetAllSupplierProductsQuery, PagedResponse<ProductResponse>>
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllSupplierProductsQueryHandler(IMapper mapper, DataContext context, IPaginationHelpers paginationHelper)
        {
            _mapper = mapper;
            _context = context;
            _paginationHelper = paginationHelper;
        }

        public async Task<PagedResponse<ProductResponse>> Handle(GetAllSupplierProductsQuery query, CancellationToken cancellationToken)
        {
            var supplier = await _context.Suppliers.SingleOrDefaultAsync(s => s.Id == query.SupplierId);
            if (supplier == null)
            {
                throw new NotFoundException();
            }
            var queryable = _context.Products.AsQueryable();
            queryable = queryable
                .Where(p => p.SupplierProducts.Any(sp => sp.SupplierId == query.SupplierId))
                .Include(p => p.SupplierProducts)
                .Include(p => p.ProductCategory);

            // var expected = await queryable
            //     .Where(p => p.SupplierProducts.Any(sp => sp.SupplierId == query.SupplierId))
            //     .Select(p => new
            //     {
            //         p,
            //         ProductCategories = p.ProductCategory,
            //         SupplierProduct = p.SupplierProducts.FirstOrDefault(sp => sp.SupplierId == query.SupplierId)
            //     })
            //     .ToListAsync();

            return await _paginationHelper.Paginate<Product, ProductResponse>(
               queryable, query
           );
        }
    }
}