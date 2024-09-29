using Microsoft.AspNetCore.Mvc;
using Dotnet.Models;

namespace Dotnet.Controllers
{
    public class QuizController : Controller
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

        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new QuizViewModel
            {
                Questions = Questions
            };
            return View(viewModel);
        }
    }
}