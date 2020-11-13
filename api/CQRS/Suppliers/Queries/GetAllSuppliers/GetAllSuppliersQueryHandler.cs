using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.Suppliers;
using api.Entities;
using api.Helpers;
using MediatR;

namespace api.CQRS.Suppliers.Queries.GetAllSuppliers
{
    public class GetAllSuppliersQueryHandler : IRequestHandler<GetAllSuppliersQuery, PagedResponse<SupplierResponse>>
    {

        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllSuppliersQueryHandler(DataContext context, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
        }

        public async Task<PagedResponse<SupplierResponse>> Handle(GetAllSuppliersQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.Suppliers.AsQueryable();
            return await _paginationHelper.Paginate<Supplier, SupplierResponse>(
                queryable, query
            );
        }
    }
}