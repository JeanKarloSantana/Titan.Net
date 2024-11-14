using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Titan.Application.Services;
using Titan.Contracts.Subscriptions;

namespace Titan.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ISubscriptionsService _subscriptionsService;

        public SubscriptionsController(ISubscriptionsService subscriptionService)
        {
            _subscriptionsService = subscriptionService;
        }

        [HttpPost]
        public IActionResult CreateSubscription(CreateSubscriptionRequest request)
        {
            var subscriptionId = _subscriptionsService.CreateSubscription(
                request.SubscriptionType.ToString(),
                request.AdminId);

            var response = new SubscriptionResponse(
                subscriptionId, 
                request.SubscriptionType);

            return Ok(response);
        }
    }
}
