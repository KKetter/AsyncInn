using Microsoft.AspNetCore.Mvc;

namespace AsyncInn.Controllers
{
    public class AmenitiesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
