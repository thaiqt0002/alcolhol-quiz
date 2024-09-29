using Microsoft.AspNetCore.Mvc;

namespace Dotnet.Controllers
{
    public class ResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RenderResultComponent(int score)
        {
            return PartialView("~/Views/Shared/Result/ResultRender.cshtml", score);
        }
    }
}