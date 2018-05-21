using System.Collections.Generic;

namespace QuizApp.Core.Models
{
    public class Question : IModel
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public string Title { get; set; }
        public IEnumerable<Option> Options { get; set; }
        public QuestionType Type { get; set; }
    }
}