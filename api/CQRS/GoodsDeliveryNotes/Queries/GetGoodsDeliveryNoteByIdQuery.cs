using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsDeliveryNotes;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using E = api.Entities;

namespace src.CQRS.GoodsDeliveryNotes.Queries
{
    public class GetGoodsDeliveryNoteByIdQuery : IRequest<Result<GoodsDeliveryNoteResponse>>
    {
        public GetGoodsDeliveryNoteByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }

    public class GetGoodsReceivingNoteByIdHandler : IRequestHandler<GetGoodsDeliveryNoteByIdQuery, Result<GoodsDeliveryNoteResponse>>
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public GetGoodsReceivingNoteByIdHandler(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Result<GoodsDeliveryNoteResponse>> Handle(
            GetGoodsDeliveryNoteByIdQuery request,
            CancellationToken cancellationToken)
        {
            var queryable = _context.GoodsDeliveryNotes.AsQueryable();
            queryable = queryable.AsNoTracking();

            queryable = queryable
                .Include(gdn => gdn.GoodsDeliveryDetails)
                    .ThenInclude(gdn => gdn.Product)
                        .ThenInclude(p => p.ProductUnits)
                .Where(
                    gdn => gdn.Id == request.Id);

            queryable = queryable
                .Join(_context.Users,
                    gdn => gdn.CreatedBy,
                    u => u.Id,
                    (gdn, u) =>
                    new E.GoodsDeliveryNote
                    {
                        Id = gdn.Id,
                        Status = gdn.Status,
                        ExceptionReason = gdn.ExceptionReason,
                        Description = gdn.Description,
                        CreatedAt = gdn.CreatedAt,
                        LastModifiedAt = gdn.LastModifiedAt,
                        OrderId = gdn.OrderId,
                        TotalPrice = gdn.TotalPrice,
                        User = u,
                        GoodsDeliveryDetails = gdn.GoodsDeliveryDetails
                    }
                );

            var goodsDeliveryNote = await queryable.FirstOrDefaultAsync();

            if (goodsDeliveryNote == null)
            {
                return new Result<GoodsDeliveryNoteResponse>(
                    new NotFoundException()
                );
            }

            return new Result<GoodsDeliveryNoteResponse>(
                _mapper.Map<GoodsDeliveryNoteResponse>(goodsDeliveryNote)
            );
        }
    }
}
