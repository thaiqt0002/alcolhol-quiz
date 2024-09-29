using Microsoft.AspNetCore.Mvc;

namespace Dotnet.Controllers
{
    public class TipsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}