using Microsoft.AspNetCore.Mvc;

namespace Blog2.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok("lock and load");
        }

    }
}
