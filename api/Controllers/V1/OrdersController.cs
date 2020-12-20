﻿using System.Collections.Generic;
using System.Threading.Tasks;
using api.Contracts.V1;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.Orders;
using api.CQRS.Orders.Commands.BulkCreateOrderDetails;
using api.CQRS.Orders.Commands.BulkUpdateOrderDetails;
using api.CQRS.Orders.Commands.CreateOrders;
using api.CQRS.Orders.Commands.UpdateOrders;
using api.CQRS.Orders.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.CQRS.Orders.Queries;

namespace api.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,Sale,WarehouseKeeper,WarehouseKeeperManager,Boss")]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = "Sale,Boss")]
        [HttpPost(ApiRoutes.Orders.Create)]
        public async Task<IActionResult> Create([FromBody] CreateOrdersCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => Created("", new Response<OrderResponse>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.Orders.GetAll)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllOrdersQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<PagedResponse<OrderResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [Authorize(Roles = "Sale,Boss")]
        [HttpPut(ApiRoutes.Orders.Update)]
        public async Task<IActionResult> Update([FromRoute] int orderId, [FromBody] UpdateOrdersCommand command)
        {
            command.Id = orderId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.Orders.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int orderId)
        {
            var query = new GetOrderByIdQuery(orderId);
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                response => Ok(new Response<OrderResponse>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [Authorize(Roles = "Sale,Boss")]
        [HttpPost(ApiRoutes.Orders.AddProductsToOrder)]
        public async Task<IActionResult> AddProductsToOrder([FromRoute] int orderId, [FromBody] BulkCreateOrderDetailsCommand command)
        {
            command.OrderId = orderId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => Created("", new Response<List<OrderDetailResponse>>(
                    response
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [Authorize(Roles = "Sale,Boss")]
        [HttpPut(ApiRoutes.Orders.BulkUpdateProductsInOrder)]
        public async Task<IActionResult> BulkUpdateProductsInOrder([FromRoute] int orderId, [FromBody] BulkUpdateOrderDetailsCommand command)
        {
            command.OrderId = orderId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                response => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        //[Authorize(Roles = "Sale,Boss")]
        //[HttpDelete(ApiRoutes.PurchaseProposalForm.BulkDeletePurchaseProposalDetail)]
        //public async Task<IActionResult> BulkDeletePurchaseProposalDetaiils([FromRoute] int purchaseProposalFormId, [FromBody] BulkDeletePurchaseProposalDetailCommand command)
        //{
        //    command.PurchaseProposalFormId = purchaseProposalFormId; 
        //    var result = await _mediator.Send(command);

        //    return result.Match<IActionResult>(
        //        purchaseProposalFormresponses => NoContent(),
        //        exp =>
        //        {
        //            throw exp;
        //        }
        //    );
        //}
    }
}
