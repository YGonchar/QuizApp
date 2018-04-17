using System.Collections.Generic;

namespace QuizApp.Core.Models
{
    public class Question : IModel
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public IEnumerable<Option> Options { get; set; }
    }
}