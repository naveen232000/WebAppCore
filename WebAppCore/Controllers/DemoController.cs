using Microsoft.AspNetCore.Mvc;

namespace WebAppCore.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
