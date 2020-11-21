using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Contracts.V1;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.Products;
using api.Contracts.V1.ResponseModels.Statistics;
using api.CQRS.Products.Commands.CreateProducts;
using api.CQRS.Products.Commands.UpdateProducts;
using api.CQRS.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.CQRS.Products.Queries;
using src.CQRS.PurchaseProposalForms.Queries;

namespace api.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,Boss")]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRoutes.Statistics.BestSellingProductsStatistic)]
        public async Task<IActionResult> GetBestSellingProducts([FromQuery] BestSellingProductsStatisticQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<List<BestSellingProductsStatisticResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.Statistics.RevenueAndExpeditureStatistic)]
        public async Task<IActionResult> GetRevenueAndExpenditure([FromQuery] RevenueAndExpenditureStatisticQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<RevenueAndExpenditureStatisticResponse>(
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
