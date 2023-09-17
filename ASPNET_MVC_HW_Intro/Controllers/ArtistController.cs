using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_HW_Intro.Controllers
{
    public class ArtistController : Controller
    {
        public IActionResult General()
        {
            return View();
        }

        public IActionResult Biography()
        {
            return View();
        }

        public IActionResult Pictures()
        {
            return View();
        }
    }
}