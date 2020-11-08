using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.Helpers;
using api.Services;
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

namespace api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail
{
    public class CreateGoodsReceivingDetailCommand : IRequest<Result<GoodsReceivingDetailResponse>>
    {
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
    }

    public class CreateGoodsReceivingDetailHandler : IRequestHandler<CreateGoodsReceivingDetailCommand, Result<GoodsReceivingDetailResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateGoodsReceivingDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<Result<GoodsReceivingDetailResponse>> Handle(
            CreateGoodsReceivingDetailCommand request,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
