using System.Collections.Generic;
using System.Threading.Tasks;
using api.Contracts.V1;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.ProductRemoveForms;
using api.CQRS.ProductRemoveForms.Commands.CreateProductRemoveDetail;
using api.CQRS.ProductRemoveForms.Commands.CreateProductRemoveForm;
using api.CQRS.ProductRemoveForms.Commands.DeleteProductRemoveDetail;
using api.CQRS.ProductRemoveForms.Commands.UpdateProductRemoveDetail;
using api.CQRS.ProductRemoveForms.Commands.UpdateProductRemoveForm;
using api.CQRS.ProductRemoveForms.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,Sale,WarehouseKeeper,WarehouseKeeperManager,Boss")]
    public class ProductRemoveFormsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductRemoveFormsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = "WarehouseKeeper,Boss,WarehouseKeeperManager")]
        [HttpPost(ApiRoutes.ProductRemoveForms.CreateProductRemoveForm)]
        public async Task<IActionResult> CreateProductRemoveForm([FromBody] CreateProductRemoveFormCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => Created("", new Response<ProductRemoveFormResponse>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [Authorize(Roles = "WarehouseKeeper,Boss,WarehouseKeeperManager")]
        [HttpPut(ApiRoutes.ProductRemoveForms.UpdateProductRemoveForm)]
        public async Task<IActionResult> UpdateProductRemoveForm(
            [FromRoute] int productRemoveFormId,
            [FromBody] UpdateProductRemoveFormCommand command)
        {
            command.Id = productRemoveFormId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.ProductRemoveForms.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int productRemoveFormId)
        {
            var query = new GetProductRemoveFormByIdQuery(productRemoveFormId);
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                response => Ok(new Response<ProductRemoveFormResponse>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.ProductRemoveForms.GetAll)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllProductRemoveFormQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<PagedResponse<ProductRemoveFormResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        /*-------------------------------------|
        |                                      |
        |         PRODUCT REMOVE DETAIL        |
        |                                      |
        |--------------------------------------| */
        [Authorize(Roles = "WarehouseKeeper,WarehouseKeeperManager,Boss")]
        [HttpPost(ApiRoutes.ProductRemoveForms.CreateProductRemoveDetail)]
        public async Task<IActionResult> CreateProductRemoveDetail(
            [FromBody] CreateProductRemoveDetailCommand command
        )
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => Created("", new Response<List<ProductRemoveDetailResponse>>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [Authorize(Roles = "WarehouseKeeper,WarehouseKeeperManager,Boss")]
        [HttpPut(ApiRoutes.ProductRemoveForms.UpdateProductRemoveDetail)]
        public async Task<IActionResult> UpdateInventoryRecordDetail(
            [FromRoute] int productRemoveFormId,
            [FromBody] UpdateProductRemoveDetailCommand command)
        {
            command.ProductRemoveFormId = productRemoveFormId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [Authorize(Roles = "WarehouseKeeper,WarehouseKeeperManager,Boss")]
        [HttpDelete(ApiRoutes.ProductRemoveForms.DeleteProductRemoveDetail)]
        public async Task<IActionResult> DeleteInventoryRecordDetail(
            [FromRoute] int productRemoveFormId,
            [FromBody] DeleteProductRemoveDetailCommand command)
        {
            command.ProductRemoveFormId = productRemoveFormId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}