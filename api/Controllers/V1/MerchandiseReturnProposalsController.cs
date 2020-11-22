using System.Threading.Tasks;
using api.Contracts.V1;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using api.CQRS.MerchandiseReturnProposals.Commands.CreateMerchandiseReturnProposal;
using api.CQRS.MerchandiseReturnProposals.Queries.GetAllMerchandiseReturnProposal;
using api.CQRS.MerchandiseReturnProposals.Queries.GetMerchandiseReturnProposalById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.V1
{
    [Authorize(Roles = "Admin,Sale,WarehouseKeeper,WarehouseKeeperManager,Boss")]

    public class MerchandiseReturnProposalsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MerchandiseReturnProposalsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = "Admin,Boss,Sale")]
        [HttpPost(ApiRoutes.MerchandiseReturnProposals.Create)]
        public async Task<IActionResult> Create([FromBody] CreateMerchandiseReturnProposalCommand command)
        {
            var result = await _mediator.Send(command);
            return Created("", result);
        }

        [Authorize(Roles = "Admin,Boss,Sale")]
        [HttpGet(ApiRoutes.MerchandiseReturnProposals.GetAll)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllMerchandiseReturnProposalQuery query)
        {
            var result = await _mediator.Send(query);
            var res = new Response<PagedResponse<MerchandiseReturnProposalResponse>>(result);
            return Ok(res);
        }

        [Authorize(Roles = "Admin,Boss,Sale")]
        [HttpGet(ApiRoutes.MerchandiseReturnProposals.GetById)]
        public async Task<IActionResult> GetBySku([FromRoute] int merchandiseReturnProposalId)
        {
            var query = new GetMerchandiseReturnProposalByIdQuery(merchandiseReturnProposalId);
            var result = await _mediator.Send(query);
            return Ok(new Response<MerchandiseReturnProposalResponse>(result));
        }
    }
}