using api.Contracts.V1;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.GoodsDeliveryNotes;
using api.CQRS.GoodsDeliveryNotes.Commands.CreateGoodsDeliveryNotes;
using api.CQRS.GoodsDeliveryNotes.Commands.UpdateGoodsDeliveryNotes;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.CQRS.GoodsDeliveryNotes.Queries;
using System.Threading.Tasks;

namespace api.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,Sale,WarehouseKeeper,WarehouseKeeperManager,Boss")]
    public class GoodsDeliveryNotesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GoodsDeliveryNotesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = "WarehouseKeeper,Boss,WarehouseKeeperManager")]
        [HttpPost(ApiRoutes.GoodsDeliveryNotes.Create)]
        public async Task<IActionResult> Create([FromBody] CreateGoodsDeliveryNotesCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => Created("", new Response<GoodsDeliveryNoteResponse>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.GoodsDeliveryNotes.GetAll)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllGoodsDeliveryNotesQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<PagedResponse<GoodsDeliveryNoteResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [Authorize(Roles = "WarehouseKeeper,Boss,WarehouseKeeperManager")]
        [HttpPut(ApiRoutes.GoodsDeliveryNotes.Update)]
        public async Task<IActionResult> Update([FromRoute] int goodsDeliveryNoteId, [FromBody] UpdateGoodsDeliveryNotesCommand command)
        {
            command.Id = goodsDeliveryNoteId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.GoodsDeliveryNotes.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int goodsDeliveryNoteId)
        {
            var query = new GetGoodsDeliveryNoteByIdQuery(goodsDeliveryNoteId);
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                response => Ok(new Response<GoodsDeliveryNoteResponse>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        //[Authorize(Roles = "WarehouseKeeper,WarehouseKeeperManager,Boss")]
        //[HttpPost(ApiRoutes.GoodsDeliveryNotes.AddProductToGoodReceivingNote)]
        //public async Task<IActionResult> AddProductToPurchaseProposalForm([FromRoute] int goodsReceivingNoteId, [FromBody] BulkCreateGoodsReceivingDetailCommand command)
        //{
        //    command.GoodsReceivingNoteId = goodsReceivingNoteId;
        //    var result = await _mediator.Send(command);

        //    return result.Match<IActionResult>(
        //        response => Created("", new Response<List<GoodsReceivingDetailResponse>>(
        //            response
        //        )),
        //        exp =>
        //        {
        //            throw exp;
        //        }
        //    );
        //}

        //[Authorize(Roles = "WarehouseKeeper,WarehouseKeeperManager,Boss")]
        //[HttpPut(ApiRoutes.GoodsDeliveryNotes.BulkUpdateProductInGoodsReceivingNote)]
        //public async Task<IActionResult> BulkUpdatePurchaseProposalDetails([FromRoute] int goodsReceivingNoteId, [FromBody] BulkUpdateGoodsReceivingDetailCommand command)
        //{
        //    command.GoodsReceivingNoteId = goodsReceivingNoteId;
        //    var result = await _mediator.Send(command);

        //    return result.Match<IActionResult>(
        //        response => NoContent(),
        //        exp =>
        //        {
        //            throw exp;
        //        }
        //    );
        //}

        //[Authorize(Roles = "WarehouseKeeper,WarehouseKeeperManager,Boss")]
        //[HttpDelete(ApiRoutes.GoodsDeliveryNotes.BulkDeleteProductInGoodsReceivingNote)]
        //public async Task<IActionResult> BulkDeletePurchaseProposalDetaiils([FromRoute] int goodsReceivingNoteId, [FromBody] BulkDeleteGoodsReceivingDetailCommand command)
        //{
        //    command.GoodsReceivingNoteId = goodsReceivingNoteId;
        //    var result = await _mediator.Send(command);

        //    return result.Match<IActionResult>(
        //        response => NoContent(),
        //        exp =>
        //        {
        //            throw exp;
        //        }
        //    );
        //}
    }
}
