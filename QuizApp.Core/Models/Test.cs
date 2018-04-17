using System.Collections.Generic;

namespace QuizApp.Core.Models
{
    public class Test : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}
