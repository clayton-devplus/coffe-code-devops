using Microsoft.AspNetCore.Mvc;

namespace CoffeCodeDevops.Controllers
{
    [ApiController]
    [Route("")]
    public class LivenessController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
