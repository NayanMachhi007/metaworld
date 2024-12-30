using Microsoft.AspNetCore.Mvc;

namespace Meta_Ads_World.Controllers
{
    public class ModuleController : Controller
    {
        public IActionResult ModuleLibrary()
        {
            return View();
        }

        public IActionResult ModuleBackup()
        {
            return View();
        }


    }
}
