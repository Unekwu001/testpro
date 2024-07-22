using Microsoft.AspNetCore.Mvc;

namespace testpro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
