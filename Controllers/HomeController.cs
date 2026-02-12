using Microsoft.AspNetCore.Mvc;

namespace FSBOCars.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
