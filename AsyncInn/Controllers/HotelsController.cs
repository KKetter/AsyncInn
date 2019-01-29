using Microsoft.AspNetCore.Mvc;

namespace AsyncInn.Controllers
{
    public class HotelsController: Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
