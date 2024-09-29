using Microsoft.AspNetCore.Mvc;

namespace Dotnet.Controllers
{
    public class TipsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Diet() {
            return View();
        }

        public IActionResult Exercise() {
            return View();
        }

        public IActionResult Medicine() {
            return View();
        }

        public IActionResult Symptom() {
            return View();
        }
    }
}