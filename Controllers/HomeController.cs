using Microsoft.AspNetCore.Mvc;

namespace Sovremennik.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
