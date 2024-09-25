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
                Question = "Are you answering these question for yourself or someone else?",
                Answers = [
                    new() { Option = "Myself", Image="/images/for_me.jpg" },
                    new() { Option = "Someone i care about", Image="/images/for_lo.jpg" },
                ]
            },
            new() {
                Question = "What is your sex?",
                Description = "We ask for your biological sex at birth because clinical suggestions right now base on biologically male or female anatomy.",
                Answers = [
                    new() { Option = "Female" },
                    new() { Option = "Male" },
                    new() { Option = "I prefer not to answer" },
                ]
            },
            new() {
                Question = "How old are you",
                Answers = [
                    new() { Option = "Under 21" },
                    new() { Option = "21-35" },
                    new() { Option = "36-50" },
                    new() { Option = "51-64" },
                    new() { Option = "65 or older" }
                ]
            },
            new() {
                Question = "On average, how <u>many days a week</u> do you have an alcoholic drink?",
                Description = "Be aware that each country has a different definition of a standard drink. In the U.S., a standard drink is...",
                Answers = [
                    new() { Option = "Less than 1 day" },
                    new() { Option = "1" },
                    new() { Option = "2" },
                    new() { Option = "3" },
                    new() { Option = "4" },
                    new() { Option = "5" },
                    new() { Option = "6" },
                    new() { Option = "7 days" }
                ]
            },
            new() {
                Question = "How many standard drinks do you have on a typical day when you are drinking?",
                Description = "A standard drink is a 12-ounce beer, 5-ounce glass of wine, or 1.5-ounce shot of distilled spirits.",
                Answers = [
                    new() { Option = "1 or 2" },
                    new() { Option = "3 or 4" },
                    new() { Option = "5 or 6" },
                    new() { Option = "7 to 9" },
                    new() { Option = "10 or more" }
                ]
            },
            new() {
                Question = "On a typical drinking day, how many <u>drinks</u> do you have?",
                Description = "<button class='text-blue-300'>Remind me of what one drink is</button>",
                Answers = [
                    new() { Option = "Less than 1 drink" },
                    new() { Option = "1" },
                    new() { Option = "2" },
                    new() { Option = "3" },
                    new() { Option = "4" },
                    new() { Option = "5" },
                    new() { Option = "6" },
                    new() { Option = "7" },
                    new() { Option = "8" },
                    new() { Option = "9" },
                    new() { Option = "10" },
                    new() { Option = "11+ drinks" },
                ]
            },
        ];

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Quiz(int questionIndex = 0)
        {
            var viewModel = new QuizViewModel
            {
                Questions = Questions
            };
            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
