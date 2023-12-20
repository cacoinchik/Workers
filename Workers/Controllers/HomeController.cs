using Microsoft.AspNetCore.Mvc;

namespace Workers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
