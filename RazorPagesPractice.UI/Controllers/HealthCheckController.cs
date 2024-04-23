using Microsoft.AspNetCore.Mvc;

namespace RazorPagesPractice.UI.Controllers
{
    [Route("v1/[controller]")]
    public class HealthCheckController : Controller
    {

        [HttpHead]
        public IActionResult Index()
        {
            return StatusCode(200);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Ok");
        }
    }
}