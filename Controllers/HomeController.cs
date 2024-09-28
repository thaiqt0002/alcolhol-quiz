using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet.Models;
using Dotnet.Models;

namespace Dotnet.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<QuestionViewModel> Questions = [
            new() {
                Question = "Giới tính của bạn?",
                Answers = [
                    new() { Option = "Nam"},
                    new() { Option = "Nữ" },
                ]
            },
            new() {
                Question = "Bạn bao nhiêu tuổi?",
                Answers = [
                    new() { Option = "12 -> 17 tuổi", Score = -1 },
                    new() { Option = "18 -> 24 tuổi"},
                ]
            },
            new() {
                Question = "Trung bình một tuần bạn uống rượu bia bao nhiêu ngày?",
                Answers = [
                    new() { Option = "1-2 ngày", Score = 1 },
                    new() { Option = "3-5 ngày", Score = 2 },
                    new() { Option = "6-7 ngày", Score = 5 },
                ]
            },
            new() {
                Question = "Trung bình 1 lần/ngày uống bạn dùng bao nhiêu lon",
                Answers = [
                    new() { Option = "1-2 lon", Score = 0 },
                    new() { Option = "3-7 lon", Score= 3 },
                    new() { Option = "Trên 8 lon", Score= 5 },
                ]
            },
        ];
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Quiz()
        {
            var viewModel = new QuizViewModel
            {
                Questions = Questions
            };
            return View(viewModel);
        }

        public IActionResult Result()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult RenderResultComponent(int score)
        {
            return PartialView("~/Views/Shared/Home/Components/ResultComponent.cshtml", score);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Resouce()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
