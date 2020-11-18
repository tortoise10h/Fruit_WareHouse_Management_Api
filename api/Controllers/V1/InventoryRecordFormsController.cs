using System.Collections.Generic;
using System.Threading.Tasks;
using api.Contracts.V1;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.InventoryRecordForms;
using api.CQRS.InventoryRecordForms.Commands.CreateInventoryDetail;
using api.CQRS.InventoryRecordForms.Commands.CreateInventoryForms;
using api.CQRS.InventoryRecordForms.Commands.DeleteInventoryDetail;
using api.CQRS.InventoryRecordForms.Commands.UpdateInventoryDetail;
using api.CQRS.InventoryRecordForms.Commands.UpdateInventoryForms;
using api.CQRS.InventoryRecordForms.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,Sale,WarehouseKeeper,WarehouseKeeperManager,Boss")]
    public class InventoryRecordFormsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public InventoryRecordFormsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = "WarehouseKeeper,Boss,WarehouseKeeperManager")]
        [HttpPost(ApiRoutes.InventoryRecordForms.CreateInventoryRecordForm)]
        public async Task<IActionResult> CreateInventoryRecordForm([FromBody] CreateInventoryFormCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => Created("", new Response<InventoryRecordFormResponse>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [Authorize(Roles = "WarehouseKeeper,Boss,WarehouseKeeperManager")]
        [HttpPut(ApiRoutes.InventoryRecordForms.UpdateInventoryRecordForm)]
        public async Task<IActionResult> UpdateInventoryRecordForm(
            [FromRoute] int inventoryRecordFormId,
            [FromBody] UpdateInventoryFormCommand command)
        {
            command.Id = inventoryRecordFormId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.InventoryRecordForms.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int inventoryRecordFormId)
        {
            var query = new GetInventoryRecordFormById(inventoryRecordFormId);
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                response => Ok(new Response<InventoryRecordFormResponse>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.InventoryRecordForms.GetAll)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllInventoryRecordFormQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<PagedResponse<InventoryRecordFormResponse>>(
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
        |       INVENTORY RECORD DETAIL        |
        |                                      |
        |--------------------------------------| */
        [Authorize(Roles = "WarehouseKeeper,WarehouseKeeperManager,Boss")]
        [HttpPost(ApiRoutes.InventoryRecordForms.CreateInventoryRecordDetail)]
        public async Task<IActionResult> CreateInventoryRecordDetail([FromBody] CreateInventoryDetailCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => Created("", new Response<List<InventoryRecordDetailResponse>>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [Authorize(Roles = "WarehouseKeeper,WarehouseKeeperManager,Boss")]
        [HttpPut(ApiRoutes.InventoryRecordForms.UpdateInventoryRecordDetail)]
        public async Task<IActionResult> UpdateInventoryRecordDetail(
            [FromRoute] int inventoryRecordFormId,
            [FromBody] UpdateInventoryDetailCommand command)
        {
            command.InventoryRecordFormId = inventoryRecordFormId;
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
        [HttpDelete(ApiRoutes.InventoryRecordForms.DeleteInventoryRecordDetail)]
        public async Task<IActionResult> DeleteInventoryRecordDetail(
            [FromRoute] int inventoryRecordFormId,
            [FromBody] DeleteInventoryDetailCommand command)
        {
            command.InventoryRecordFormId = inventoryRecordFormId;
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