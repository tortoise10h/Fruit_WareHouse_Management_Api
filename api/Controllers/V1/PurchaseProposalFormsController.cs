using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Contracts.V1;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.CQRS.Products.Queries;
using api.CQRS.PurchaseProposalForms.Commands.BulkCreatePurchaseProposalDetails;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.UpdateProducts;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using src.CQRS.Products.Queries;
using src.CQRS.PurchaseProposalForms.Queries;

namespace api.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,Sale,WarehouseKeeper,WarehouseKeeperManager")]
    public class PurchaseProposalFormsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PurchaseProposalFormsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(ApiRoutes.PurchaseProposalForm.Create)]
        public async Task<IActionResult> Create([FromBody] CreatePurchaseProposalFormCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                purchaseProposalFormresponse => Created("", new Response<PurchaseProposalFormResponse>(
                    purchaseProposalFormresponse
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.PurchaseProposalForm.GetAll)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllPurchaseProposalFormQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<PagedResponse<PurchaseProposalFormResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpPut(ApiRoutes.PurchaseProposalForm.Update)]
        public async Task<IActionResult> Update([FromRoute] int purchaseProposalFormId, [FromBody] UpdatePurchaseProposalFormCommand command) 
        {
            command.Id = purchaseProposalFormId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                purchaseProposalFormresponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.PurchaseProposalForm.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int purchaseProposalFormId)
        {
            var query = new GetPurchaseProposalFormByIdQuery(purchaseProposalFormId);
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                purchaseProposalFormResponse => Ok(new Response<PurchaseProposalFormResponse>(
                    purchaseProposalFormResponse
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpPost(ApiRoutes.PurchaseProposalForm.AddProductToPurchaseProposalForm)]
        public async Task<IActionResult> AddProductToPurchaseProposalForm([FromRoute] int purchaseProposalFormId, [FromBody] BulkCreatePurchaseProposalDetailCommand command)
        {
            command.PurchaseProposalFormId = purchaseProposalFormId; 
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                purchaseProposalFormresponses => Created("", new Response<List<PurchaseProposalDetailResponse>>(
                    purchaseProposalFormresponses
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}
