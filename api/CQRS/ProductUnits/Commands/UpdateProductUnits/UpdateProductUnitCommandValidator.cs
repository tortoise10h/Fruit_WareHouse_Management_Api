﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.ProductUnits.Commands.UpdateProductUnits
{
    public class UpdateProductUnitCommandValidator: AbstractValidator<UpdateProductUnitCommand>
    {
        public UpdateProductUnitCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                    .WithMessage("Tên của đơn vị tính không được để trống")
                .MaximumLength(255)
                    .WithMessage("Tên của đơn vị tính tối đa là 255 ký tự");

            RuleFor(x => x.RatioFromDefault)
                .NotNull()
                    .WithMessage("Tỉ lệ của đơn vị tính mới so với đơn vị tính mặc định của sản phẩm không được để trống")
                .GreaterThan(0)
                .WithMessage("Tỉ lệ của đơn vị tính mới so với đơn vị tính mặc định của sản phẩm không nhỏ hơn 0");
        }
    }
}
