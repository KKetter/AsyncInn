﻿using Microsoft.AspNetCore.Mvc;

namespace AsyncInn.Controllers
{
    /// <summary>
    /// This method renders the main page on startup
    /// </summary>
    public class HomeController: Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
