using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.Contracts.V1.ResponseModels.Statistics;
using api.Helpers;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using E = api.Entities;

namespace src.CQRS.PurchaseProposalForms.Queries
{
    public class BestSellingProductsStatisticQuery : IRequest<Result<List<BestSellingProductsStatisticResponse>>>
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }

    public class BestSellingProductsStatisticHandler : IRequestHandler<BestSellingProductsStatisticQuery, Result<List<BestSellingProductsStatisticResponse>>>
    {
        private readonly DataContext _context;

        public BestSellingProductsStatisticHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Result<List<BestSellingProductsStatisticResponse>>> Handle(BestSellingProductsStatisticQuery query, CancellationToken cancellationToken)
        {
            var doneOrderIds = await _context.Orders
                .Where(x => (x.Status == OrderStatus.Done || x.Status == OrderStatus.Exported) &&
                    x.CreatedAt >= query.FromDate &&
                    x.CreatedAt <= query.ToDate)
                .Select(x => x.Id)
                .ToListAsync();


            var bestSellingList = await _context.OrderDetails
                .Where(x => doneOrderIds.Contains(x.OrderId))
                .GroupBy(x => x.ProductId)
                .Select(x => x)
                .Select(x => new
                {
                    NumberOfProducts = x.Count(),
                    ProductId = x.Key,
                    TotalQuantitySold = x.Sum(x => x.Quantity),
                    TotalPrice = x.Sum(x => x.TotalPrice),
                })
                .OrderByDescending(x => x.TotalQuantitySold)
                .Take(10)
                .ToListAsync();

            var bestSellingProductIds = bestSellingList
                .Select(x => x.ProductId)
                .ToList();
            var bestSellingProducts = await _context.Products
                .Where(x => bestSellingProductIds.Contains(x.Id))
                .ToListAsync();

            List<BestSellingProductsStatisticResponse> result = new List<BestSellingProductsStatisticResponse>();
            foreach (var item in bestSellingList)
            {
                var matchedProduct = bestSellingProducts
                    .SingleOrDefault(x => x.Id == item.ProductId);
                result.Add(new BestSellingProductsStatisticResponse
                {
                    NumberOfProducts = item.NumberOfProducts,
                    ProductId = item.ProductId,
                    TotalQuantitySold = item.TotalQuantitySold,
                    TotalPrice = item.TotalPrice,
                    ProductName = matchedProduct.Name,
                    ProductSKU = matchedProduct.SKU,
                    ProductDefaultUnit = matchedProduct.DefaultUnit
                });
            }
            return result;
        }
    }
}