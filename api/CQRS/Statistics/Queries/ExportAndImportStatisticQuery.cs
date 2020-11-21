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
    public class ExportAndImportStatisticQuery : IRequest<Result<ExportAndImportStatisticResponse>>
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }

    public class ExportAndImportStatisticHandler : IRequestHandler<ExportAndImportStatisticQuery, Result<ExportAndImportStatisticResponse>>
    {
        private readonly DataContext _context;

        public ExportAndImportStatisticHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Result<ExportAndImportStatisticResponse>> Handle(ExportAndImportStatisticQuery query, CancellationToken cancellationToken)
        {
            var orderResult = await _context.Orders
                .Where(x => x.CreatedAt.Date.CompareTo(query.FromDate.Date) >= 0 &&
                    x.CreatedAt.Date.CompareTo(query.ToDate.Date) <= 0)
                .GroupBy(x => x.Status)
                .Select(item => new
                {
                    Amount = item.Count(),
                    Status = item.Key
                })
                .ToListAsync();

            var exportResult = await _context.GoodsDeliveryNotes
                .Where(x => x.CreatedAt.Date.CompareTo(query.FromDate.Date) >= 0 &&
                    x.CreatedAt.Date.CompareTo(query.ToDate.Date) <= 0)
                .GroupBy(x => x.Status)
                .Select(item => new
                {
                    Amount = item.Count(),
                    Status = item.Key
                })
                .ToListAsync();

            var purchaseProposalFormResult = await _context.PurchaseProposalForms
                .Where(x => x.CreatedAt.Date.CompareTo(query.FromDate.Date) >= 0 &&
                    x.CreatedAt.Date.CompareTo(query.ToDate.Date) <= 0)
                .GroupBy(x => x.Status)
                .Select(item => new
                {
                    Amount = item.Count(),
                    Status = item.Key
                })
                .ToListAsync();
            
            var importResult = await _context.GoodsReceivingNotes
                .Where(x => x.CreatedAt.Date.CompareTo(query.FromDate.Date) >= 0 &&
                    x.CreatedAt.Date.CompareTo(query.ToDate.Date) <= 0)
                .GroupBy(x => x.Status)
                .Select(item => new
                {
                    Amount = item.Count(),
                    Status = item.Key
                })
                .ToListAsync();

            return new ExportAndImportStatisticResponse
            {
                Order = new
                {
                    Total = orderResult.Sum(x => x.Amount),
                    Details = orderResult
                },
                GoodsDeliveryNote = new
                {
                    Total = exportResult.Sum(x => x.Amount),
                    Details = exportResult
                },
                PurchaseProposalForm = new
                {
                    Total = purchaseProposalFormResult.Sum(x => x.Amount),
                    Details = purchaseProposalFormResult
                },
                GoodsReceivingNote = new
                {
                    Total = importResult.Sum(x => x.Amount),
                    Details = importResult
                },
            };
        }
    }
}