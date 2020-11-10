using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Contracts.V1;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
using api.CQRS.GoodsReceivingNotes.Commands.BulkCreateGoodsReceivingDetails;
using api.CQRS.GoodsReceivingNotes.Commands.BulkDeleteGoodsReceivingDetail;
using api.CQRS.GoodsReceivingNotes.Commands.BulkUpdateGoodsReceivingDetail;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingNote;
using api.CQRS.GoodsReceivingNotes.Commands.UpdateGoodsReceivingNote;
using api.CQRS.GoodsReceivingNotes.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.CQRS.GoodsReceivingNotes.Queries;

namespace api.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,Sale,WarehouseKeeper,WarehouseKeeperManager")]
    public class GoodsReceivingNotesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GoodsReceivingNotesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = "WarehouseKeeper,Boss,WarehouseKeeperManager")]
        [HttpPost(ApiRoutes.GoodsReceivingNotes.Create)]
        public async Task<IActionResult> Create([FromBody] CreateGoodsReceivingNoteCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                goodsReceivingNoteRespone => Created("", new Response<GoodsReceivingNoteResponse>(
                    goodsReceivingNoteRespone
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.GoodsReceivingNotes.GetAll)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllGoodsReceivingNotesQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<PagedResponse<GoodsReceivingNoteResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [Authorize(Roles = "WarehouseKeeper,Boss,WarehouseKeeperManager")]
        [HttpPut(ApiRoutes.GoodsReceivingNotes.Update)]
        public async Task<IActionResult> Update([FromRoute] int goodsReceivingNoteId, [FromBody] UpdateGoodsReceivingNoteCommand command)
        {
            command.Id = goodsReceivingNoteId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                GoodsReceivingNoteResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.GoodsReceivingNotes.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int goodsReceivingNoteId)
        {
            var query = new GetGoodsReceivingNoteByIdQuery(goodsReceivingNoteId);
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                goodsReceivingNoteResponse => Ok(new Response<GoodsReceivingNoteResponse>(
                    goodsReceivingNoteResponse
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [Authorize(Roles = "WarehouseKeeper,WarehouseKeeperManager,Boss")]
        [HttpPost(ApiRoutes.GoodsReceivingNotes.AddProductToGoodReceivingNote)]
        public async Task<IActionResult> AddProductToPurchaseProposalForm([FromRoute] int goodsReceivingNoteId, [FromBody] BulkCreateGoodsReceivingDetailCommand command)
        {
            command.GoodsReceivingNoteId = goodsReceivingNoteId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => Created("", new Response<List<GoodsReceivingDetailResponse>>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [Authorize(Roles = "WarehouseKeeper,WarehouseKeeperManager,Boss")]
        [HttpPut(ApiRoutes.GoodsReceivingNotes.BulkUpdateProductInGoodsReceivingNote)]
        public async Task<IActionResult> BulkUpdatePurchaseProposalDetails([FromRoute] int goodsReceivingNoteId, [FromBody] BulkUpdateGoodsReceivingDetailCommand command)
        {
            command.GoodsReceivingNoteId = goodsReceivingNoteId;
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
        [HttpDelete(ApiRoutes.GoodsReceivingNotes.BulkDeleteProductInGoodsReceivingNote)]
        public async Task<IActionResult> BulkDeletePurchaseProposalDetaiils([FromRoute] int goodsReceivingNoteId, [FromBody] BulkDeleteGoodsReceivingDetailCommand command)
        {
            command.GoodsReceivingNoteId = goodsReceivingNoteId;
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
