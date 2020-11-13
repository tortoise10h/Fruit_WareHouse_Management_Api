using System.Threading.Tasks;
using api.Contracts.V1;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.Suppliers;
using api.CQRS.Suppliers.Commands.AddProductsToSupplier;
using api.CQRS.Suppliers.Commands.CreateSupplier;
using api.CQRS.Suppliers.Commands.DeleteSupplier;
using api.CQRS.Suppliers.Commands.RemoveProductsFromSupplier;
using api.CQRS.Suppliers.Commands.UpdateSupplier;
using api.CQRS.Suppliers.Queries.GetAllSupplierProducts;
using api.CQRS.Suppliers.Queries.GetAllSuppliers;
using api.CQRS.Suppliers.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.V1
{
    public class SuppliersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SuppliersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = "Admin,Boss")]
        [HttpPost(ApiRoutes.Suppliers.Create)]
        public async Task<IActionResult> Create([FromBody] CreateSupplierCommand command)
        {
            var result = await _mediator.Send(command);
            return Created("", result);
        }

        [Authorize(Roles = "Admin,Boss")]
        [HttpPut(ApiRoutes.Suppliers.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] int supplierId,
            [FromBody] UpdateSupplierCommand command)
        {
            command.Id = supplierId;
            await _mediator.Send(command);
            return NoContent();
        }


        [Authorize(Roles = "Admin,Boss")]
        [HttpGet(ApiRoutes.Suppliers.GetAll)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllSuppliersQuery query)
        {
            var result = await _mediator.Send(query);
            var res = new Response<PagedResponse<SupplierResponse>>(result);
            return Ok(res);
        }


        [HttpGet(ApiRoutes.Suppliers.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int supplierId)
        {
            var query = new GetSupplierByIdQuery(supplierId);
            var result = await _mediator.Send(query);
            var res = new Response<SupplierResponse>(result);
            return Ok(res);
        }

        [Authorize(Roles = "Admin,Boss")]
        [HttpDelete(ApiRoutes.Suppliers.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int supplierId)
        {
            var deleteCommand = new DeleteSupplierCommand(supplierId);
            await _mediator.Send(deleteCommand);
            return NoContent();
        }

        [Authorize(Roles = "Admin,Boss")]
        [HttpPost(ApiRoutes.Suppliers.AddProductsToSupplier)]
        public async Task<IActionResult> AddProductsToSupplier([FromRoute] int supplierId, [FromBody] AddProductsToSupplierCommand command)
        {
            command.SupplierId = supplierId;
            var result = await _mediator.Send(command);
            return Created("", result);
        }

        [Authorize(Roles = "Admin,Boss")]
        [HttpGet(ApiRoutes.Suppliers.GetAllSupplierProducts)]
        public async Task<IActionResult> GetAllSupplierProducts([FromRoute] int supplierId, [FromQuery] GetAllSupplierProductsQuery query)
        {
            query.SupplierId = supplierId;
            var result = await _mediator.Send(query);
            var res = new Response<PagedResponse<SupplierProductResponse>>(result);
            return Ok(res);
        }

        [Authorize(Roles = "Admin,Boss")]
        [HttpDelete(ApiRoutes.Suppliers.RemoveProductsFromSupplier)]
        public async Task<IActionResult> RemoveProductsFromSupplier([FromRoute] int supplierId, [FromBody] RemoveProductsFromSupplierCommand command)
        {
            command.SupplierId = supplierId;
            await _mediator.Send(command);
            return NoContent();
        }
    }
}