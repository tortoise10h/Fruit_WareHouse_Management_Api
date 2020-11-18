using FluentValidation;

namespace api.CQRS.InventoryRecordForms.Commands.CreateInventoryForms
{
    public class CreateInventoryFormCommandValidator : AbstractValidator<CreateInventoryFormCommand>
    {
        public CreateInventoryFormCommandValidator()
        {

        }
    }
}