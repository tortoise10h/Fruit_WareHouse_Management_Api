using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.ResponseModels.Statistics;
using api.Helpers;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using E = api.Entities;

namespace src.CQRS.PurchaseProposalForms.Queries
{
    public class RevenueAndExpeditureStatisticQuery : IRequest<Result<RevenueAndExpeditureStatisticResponse>>
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }

    public class RevenueAndExpeditureStatisticHandler : IRequestHandler<RevenueAndExpeditureStatisticQuery, Result<RevenueAndExpeditureStatisticResponse>>
    {
        private readonly DataContext _context;

        public RevenueAndExpeditureStatisticHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Result<RevenueAndExpeditureStatisticResponse>> Handle(RevenueAndExpeditureStatisticQuery query, CancellationToken cancellationToken)
        {
            var succeededOrders = await _context.Orders
                .Where(x => x.Status == OrderStatus.Done &&
                    x.CreatedAt.Date.CompareTo(query.FromDate.Date) >= 0 &&
                    x.CreatedAt.Date.CompareTo(query.ToDate.Date) <= 0)
                .Include(x => x.OrderDetails)
                .ToListAsync();

            double revenue = 0;
            foreach (var order in succeededOrders)
            {
                double revenueOfSinlgeOrder = order.OrderDetails
                    .Sum(od => (od.Quantity * od.SinglePrice) - (od.QuantityReturned * od.SinglePrice));

                revenue += revenueOfSinlgeOrder;
            }

            var expediture = _context.GoodsReceivingNotes
                .Where(x => x.Status == GoodsReceivingNoteStatus.Done && 
                    x.CreatedAt.Date.CompareTo(query.FromDate.Date) >= 0 &&
                    x.CreatedAt.Date.CompareTo(query.ToDate.Date) <= 0)
                .Sum(x => x.TotalPrice);

            return new RevenueAndExpeditureStatisticResponse
            {
                Revenue = revenue,
                Expediture = expediture
            };
        }
    }
}