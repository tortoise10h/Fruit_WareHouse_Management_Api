using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Contracts.V1;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.ProductUnits;
using api.CQRS.ProductUnits.Commands.CreateProductUnits;
using api.CQRS.ProductUnits.Commands.DeleteProductUnits;
using api.CQRS.ProductUnits.Commands.UpdateProductUnits;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    public class ProductUnitsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductUnitsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(ApiRoutes.ProductUnit.Create)]
        public async Task<IActionResult> Create([FromBody] CreateProductUnitCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                productUnitResponse => Created("", new Response<ProductUnitResponse>(
                    productUnitResponse
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpPut(ApiRoutes.ProductUnit.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] int productUnitId,
            [FromBody] UpdateProductUnitCommand command)
        {
            command.Id = productUnitId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                productResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpDelete(ApiRoutes.ProductUnit.Delete)]
        public async Task<IActionResult> Delete(
            [FromRoute] int productUnitId
        )
        {
            var deleteCommand = new DeleteProductUnitCommand(productUnitId);
            var result = await _mediator.Send(deleteCommand);

            return result.Match<IActionResult>(
                productResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}
