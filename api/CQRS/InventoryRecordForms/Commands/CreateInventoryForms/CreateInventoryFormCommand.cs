using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.InventoryRecordForms;
using api.Entities;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;

namespace api.CQRS.InventoryRecordForms.Commands.CreateInventoryForms
{
    public class CreateInventoryFormCommand : IRequest<Result<InventoryRecordFormResponse>>
    {
        public string Description { get; set; }
    }

    public class CreateInventoryFormHandler : IRequestHandler<CreateInventoryFormCommand, Result<InventoryRecordFormResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public CreateInventoryFormHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<InventoryRecordFormResponse>> Handle(CreateInventoryFormCommand request, CancellationToken cancellationToken)
        {
            var inventoryRecordForm = _mapper.Map<InventoryRecordForm>(request);
            inventoryRecordForm.Status = InventoryRecordFormStatus.New;

            await _context.AddAsync(inventoryRecordForm);
            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<InventoryRecordFormResponse>(
                    _mapper.Map<InventoryRecordFormResponse>(inventoryRecordForm)
                );
            }

            return new Result<InventoryRecordFormResponse>(
               new BadRequestException(new ApiError("Tạo phiếu kiểm kho thất bại, vui lòng thử lại"))
            );
        }
    }
}