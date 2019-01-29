using Microsoft.AspNetCore.Mvc;

namespace AsyncInn.Controllers
{
    public class RoomToHotelController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
