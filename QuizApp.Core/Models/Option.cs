namespace QuizApp.Core.Models
{
    public class Option : IModel
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }
    }
}