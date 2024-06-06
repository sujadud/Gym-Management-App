using GymManagement.Contracts.Subscriptions;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api;

[ApiController]
[Route("[controller]")]
public class SubscriptionsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateSubscription(CreateSubscriptionRequest request)
    {
        return Ok(request);
    }

}
 