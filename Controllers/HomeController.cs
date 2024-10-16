using Meta_Ads_World.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Meta_Ads_World.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult registration()
        {
            return View();
        }

        public IActionResult login()
        {
            return View();
        }
    }
}
