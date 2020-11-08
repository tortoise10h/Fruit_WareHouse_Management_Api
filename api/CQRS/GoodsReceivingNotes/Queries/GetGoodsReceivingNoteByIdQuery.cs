using api.Contracts.V1.Exceptions;
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

namespace api.CQRS.GoodsReceivingNotes.Queries
{
    public class GetGoodsReceivingNoteByIdQuery : IRequest<Result<GoodsReceivingNoteResponse>>
    {
        public GetGoodsReceivingNoteByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }

    public class GetGoodsReceivingNoteByIdHandler : IRequestHandler<GetGoodsReceivingNoteByIdQuery, Result<GoodsReceivingNoteResponse>>
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public GetGoodsReceivingNoteByIdHandler(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Result<GoodsReceivingNoteResponse>> Handle(
            GetGoodsReceivingNoteByIdQuery request,
            CancellationToken cancellationToken)
        {
            // TODO: include supplier of this goods receiving note (if exists)
            var queryable = _context.GoodsReceivingNotes.AsQueryable();
            queryable = queryable.AsNoTracking();

            queryable = queryable
                .Include(grn => grn.GoodsReceivingDetails)
                    .ThenInclude(grd => grd.Product)
                        .ThenInclude(p => p.ProductUnits)
                .Where(
                    grn => grn.Id == request.Id);

            queryable = queryable
                .Join(_context.Users,
                    grn => grn.CreatedBy,
                    u => u.Id,
                    (grn, u) =>
                    new E.GoodsReceivingNote
                    {
                        Id = grn.Id,
                        Status = grn.Status,
                        SupplierName = grn.SupplierName,
                        SupplierId = grn.SupplierId,
                        ExceptionReason = grn.ExceptionReason,
                        Description = grn.Description,
                        TotalPrice = grn.TotalPrice,
                        CreatedAt = grn.CreatedAt,
                        LastModifiedAt = grn.LastModifiedAt,
                        User = u,
                        GoodsReceivingDetails = grn.GoodsReceivingDetails
                    }
                );

            var goodsReceivingNote = await queryable.FirstOrDefaultAsync(); 

            if (goodsReceivingNote == null)
            {
                return new Result<GoodsReceivingNoteResponse>(
                    new NotFoundException()
                );
            }

            return new Result<GoodsReceivingNoteResponse>(
                _mapper.Map<GoodsReceivingNoteResponse>(goodsReceivingNote)
            );
        }
    }
}
