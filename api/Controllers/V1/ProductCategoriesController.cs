using System.Threading.Tasks;
using api.Contracts.V1;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.ProductCategories;
using api.CQRS.ProductCategories.Commands.CreateProductCategory;
using api.CQRS.ProductCategories.Commands.DeleteProductCategory;
using api.CQRS.ProductCategories.Commands.UpdateProductCategory;
using api.CQRS.ProductCategories.Queries.GetAllProductCategories;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.V1
{
    public class ProductCategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductCategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = "Admin,Boss")]
        [HttpPost(ApiRoutes.ProductCategories.Create)]
        public async Task<IActionResult> Create([FromBody] CreateProductCategoryCommand command)
        {
            var result = await _mediator.Send(command);
            return Created("", result);
        }

        [Authorize]
        [HttpGet(ApiRoutes.ProductCategories.GetAll)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllProductCategoriesQuery query)
        {
            var result = await _mediator.Send(query);
            var res = new Response<PagedResponse<ProductCategoryResponse>>(result);
            return Ok(res);
        }

        [Authorize(Roles = "Admin,Boss")]
        [HttpPut(ApiRoutes.ProductCategories.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] int productCategoryId,
            [FromBody] UpdateProductCategoryCommand command)
        {
            command.Id = productCategoryId;
            await _mediator.Send(command);
            return NoContent();
        }


        [Authorize(Roles = "Admin,Boss")]
        [HttpDelete(ApiRoutes.ProductCategories.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int productCategoryId)
        {
            var deleteCommand = new DeleteProductCategoryCommand(productCategoryId);
            await _mediator.Send(deleteCommand);
            return NoContent();
        }
    }
}
