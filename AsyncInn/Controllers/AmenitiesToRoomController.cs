using Microsoft.AspNetCore.Mvc;

namespace AsyncInn.Controllers
{
    public class AmenitiesToRoomController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
