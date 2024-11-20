using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Titan.Application.Commands.CreateSubscription;
using Titan.Application.Services;
using Titan.Contracts.Subscriptions;

namespace Titan.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ISender _mediator;

        public SubscriptionsController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubscription(CreateSubscriptionRequest request)
        {
            var command = new CreateSubscriptionCommand(
                request.SubscriptionType.ToString(), 
                request.AdminId);

            var subscriptionId = await _mediator.Send(command);

            var response = new SubscriptionResponse(
                subscriptionId, 
                request.SubscriptionType);

            return Ok(response);
        }
    }
}
