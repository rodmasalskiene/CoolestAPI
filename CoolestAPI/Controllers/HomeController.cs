using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoolestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;    

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTest")]
        public ActionResult Index()
        {
            return Ok("Foi?");
            //return View("Home/Index");
        }
    }
}
