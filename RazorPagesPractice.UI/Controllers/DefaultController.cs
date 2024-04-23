using Microsoft.AspNetCore.Mvc;

namespace RazorPagesPractice.UI.Controllers
{
    [ApiController]
    public class DefaultController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Transaction");
        }
    }
}