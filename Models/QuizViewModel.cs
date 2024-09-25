namespace Dotnet.Models
{
    public class QuizViewModel
    {
        public List<QuestionViewModel> Questions { get; set; } = [];
    }
    public class QuestionViewModel
    {
        public string Question { get; set; } = "";
        public string Description { get; set; } = "";
        public List<AnswerViewModel> Answers { get; set; } = [];
    }

    public class AnswerViewModel
    {
        public string Image { get; set; } = "";
        public string Option { get; set; } = "";
    }
}