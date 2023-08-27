using Microsoft.AspNetCore.Mvc;

namespace CycleWeb.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReadMore()
        {
            return View();
        }
    }
}
