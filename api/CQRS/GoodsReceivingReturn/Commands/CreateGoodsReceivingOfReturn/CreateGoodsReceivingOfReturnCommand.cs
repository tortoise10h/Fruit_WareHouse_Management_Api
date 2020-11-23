using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsReceivingReturn;
using api.Entities;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.GoodsReceivingReturn.Commands.CreateGoodsReceivingOfReturn
{
    public class CreateGoodsReceivingOfReturnCommand : IRequest<Result<GoodsReceivingOfReturnResponse>>
    {
        public int MerchandiseReturnProposalId { get; set; }
        public string Description { get; set; }
    }

    public class CreateGoodsReceivingOfReturnHandler : IRequestHandler<CreateGoodsReceivingOfReturnCommand, Result<GoodsReceivingOfReturnResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateGoodsReceivingOfReturnHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GoodsReceivingOfReturnResponse>> Handle(CreateGoodsReceivingOfReturnCommand request, CancellationToken cancellationToken)
        {
            var check = await _context.MerchandiseReturnProposals
                .FirstOrDefaultAsync(x => x.Id == request.MerchandiseReturnProposalId &&
                                        x.Status == MerchandiseReturnProposalStatus.Processing);

            if (check == null)
            {
                return new Result<GoodsReceivingOfReturnResponse>(
                    new NotFoundException()
                );
            }

            var goodsReceivingOfReturn = _mapper.Map<GoodsReceivingOfReturn>(request);
            goodsReceivingOfReturn.Status = GoodsReceivingOfReturnStatus.New;

            await _context.AddAsync(goodsReceivingOfReturn);
            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<GoodsReceivingOfReturnResponse>(
                    _mapper.Map<GoodsReceivingOfReturnResponse>(goodsReceivingOfReturn)
                );
            }

            return new Result<GoodsReceivingOfReturnResponse>(
               new BadRequestException(new ApiError("Tạo phiếu nhập kho trả hàng thất bại, vui lòng thử lại"))
            );
        }
    }
}