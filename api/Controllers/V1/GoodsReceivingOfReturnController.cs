using System.Threading.Tasks;
using api.Contracts.V1;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.GoodsReceivingReturn;
using api.CQRS.GoodsReceivingReturn.Commands.CreateGoodsReceivingOfReturn;
using api.CQRS.GoodsReceivingReturn.Commands.UpdateGoodsReceivingOfReturn;
using api.CQRS.GoodsReceivingReturn.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,Sale,WarehouseKeeper,WarehouseKeeperManager,Boss")]
    public class GoodsReceivingOfReturnController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GoodsReceivingOfReturnController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = "WarehouseKeeper,Boss,WarehouseKeeperManager")]
        [HttpPost(ApiRoutes.GoodsReceivingOfReturn.CreateGoodsReceivingOfReturn)]
        public async Task<IActionResult> CreateGoodsReceivingOfReturn([FromBody] CreateGoodsReceivingOfReturnCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => Created("", new Response<GoodsReceivingOfReturnResponse>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [Authorize(Roles = "WarehouseKeeper,Boss,WarehouseKeeperManager")]
        [HttpPut(ApiRoutes.GoodsReceivingOfReturn.UpdateGoodsReceivingOfReturn)]
        public async Task<IActionResult> UpdateGoodsReceivingOfReturn(
            [FromRoute] int goodsReceivingOfReturnId,
            [FromBody] UpdateGoodsReceivingOfReturnCommand command)
        {
            command.Id = goodsReceivingOfReturnId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.GoodsReceivingOfReturn.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int goodsReceivingOfReturnId)
        {
            var query = new GetGoodsReceivingOfReturnById(goodsReceivingOfReturnId);
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                response => Ok(new Response<GoodsReceivingOfReturnResponse>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.GoodsReceivingOfReturn.GetAll)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllGoodsReceivingOfReturnQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<PagedResponse<GoodsReceivingOfReturnResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}