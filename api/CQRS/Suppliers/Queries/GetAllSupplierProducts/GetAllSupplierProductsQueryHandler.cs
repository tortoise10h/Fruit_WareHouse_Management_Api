using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.Suppliers;
using api.Entities;
using api.Helpers;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.Suppliers.Queries.GetAllSupplierProducts
{
    public class GetAllSupplierProductsQueryHandler : IRequestHandler<GetAllSupplierProductsQuery, PagedResponse<SupplierProductResponse>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllSupplierProductsQueryHandler(DataContext context, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
        }

        public async Task<PagedResponse<SupplierProductResponse>> Handle(GetAllSupplierProductsQuery query, CancellationToken cancellationToken)
        {
            var supplier = await _context.Suppliers.SingleOrDefaultAsync(s => s.Id == query.SupplierId);
            if (supplier == null)
            {
                throw new NotFoundException();
            }

            var queryable = _context.SupplierProducts.AsQueryable();
            queryable = queryable
                .Where(sp => sp.SupplierId == query.SupplierId)
                .Include(sp => sp.Product)
                .ThenInclude(p => p.ProductCategory);

            query.SortName = "ProductId";

            return await _paginationHelper.Paginate<SupplierProduct, SupplierProductResponse>(
               queryable, query
           );
        }
    }
}