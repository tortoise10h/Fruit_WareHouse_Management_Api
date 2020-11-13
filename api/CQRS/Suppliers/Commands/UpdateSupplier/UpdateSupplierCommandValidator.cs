using FluentValidation;

namespace api.CQRS.Suppliers.Commands.UpdateSupplier
{
    public class UpdateSupplierCommandValidator : AbstractValidator<UpdateSupplierCommand>
    {
        public UpdateSupplierCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .GreaterThan(0)
                .WithMessage("Id của nhà cung cấp không hợp lệ");

            RuleFor(x => x.Name)
                          .NotEmpty()
                              .WithMessage("Tên của nhà cung cấp không được để trống")
                          .MaximumLength(255)
                              .WithMessage("Tên của nhà cung cấp tối đa là 255 ký tự");

            RuleFor(x => x.Address)
                .NotEmpty()
                   .WithMessage("Địa chỉ nhà cung cấp không được để trống")
                .MaximumLength(255)
                    .WithMessage("Địa chỉ của nhà cung cấp tối đa là 255 ký tự");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                   .WithMessage("Số điện thoại nhà cung cấp không được để trống")
               .MaximumLength(255)
                   .WithMessage("Số địa thoại của nhà cung cấp tối đa là 255 ký tự");

            RuleFor(x => x.Email)
                .MaximumLength(255)
                    .WithMessage("Địa chỉ email của nhà cung cấp tối đa là 255 ký tự");

            RuleFor(x => x.Representative)
               .MaximumLength(255)
                   .WithMessage("Người đại diện của nhà cung cấp tối đa là 255 ký tự");

            RuleFor(x => x.Status)
                .IsInEnum()
                    .WithMessage("Trạng thái của nhà cung cấp không hợp lệ");
        }
    }
}