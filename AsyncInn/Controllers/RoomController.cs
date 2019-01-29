using Microsoft.AspNetCore.Mvc;

namespace AsyncInn.Controllers
{
    public class RoomController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}