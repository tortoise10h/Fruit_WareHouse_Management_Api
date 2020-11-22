using System.Threading.Tasks;
using api.Contracts.V1;
using api.CQRS.MerchandiseReturnProposals.Commands.CreateMerchandiseReturnProposal;
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

        [Authorize(Roles = "Admin,Boss")]
        [HttpPost(ApiRoutes.MerchandiseReturnProposals.Create)]
        public async Task<IActionResult> Create([FromBody] CreateMerchandiseReturnProposalCommand command)
        {
            var result = await _mediator.Send(command);
            return Created("", result);
        }
    }
}