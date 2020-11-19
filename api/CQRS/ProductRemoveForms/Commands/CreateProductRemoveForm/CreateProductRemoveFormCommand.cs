using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.ProductRemoveForms;
using api.Entities;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;

namespace api.CQRS.ProductRemoveForms.Commands.CreateProductRemoveForm
{
    public class CreateProductRemoveFormCommand : IRequest<Result<ProductRemoveFormResponse>>
    {
        public string Description { get; set; }
    }

    public class CreateProductRemoveFormHandler : IRequestHandler<CreateProductRemoveFormCommand, Result<ProductRemoveFormResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateProductRemoveFormHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<ProductRemoveFormResponse>> Handle(CreateProductRemoveFormCommand request, CancellationToken cancellationToken)
        {
            var productRemoveForm = _mapper.Map<ProductRemoveForm>(request);
            productRemoveForm.Status = ProductRemoveFormStatus.New;

            await _context.AddAsync(productRemoveForm);
            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<ProductRemoveFormResponse>(
                    _mapper.Map<ProductRemoveFormResponse>(productRemoveForm)
                );
            }

            return new Result<ProductRemoveFormResponse>(
               new BadRequestException(new ApiError("Tạo phiếu huỷ sản phẩm trong kho thất bại, vui lòng thử lại"))
            );
        }
    }
}