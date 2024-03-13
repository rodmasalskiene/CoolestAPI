using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoolestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            ViewData["Message"] = "funciona pelo amor de Deus";
            return View("Index");
        }
    }
}
