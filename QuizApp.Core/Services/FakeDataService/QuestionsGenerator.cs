using QuizApp.Core.Models;
using System.Linq;

namespace QuizApp.DataGenerator
{
    public class QuestionsGenerator : IGenerator<Question>
    {
        private readonly int optionsCount;
        private readonly IGenerator<Option> optionsGenerator;
        private static int _questionId;

        public QuestionsGenerator(int optionsCount, IGenerator<Option> optionsGenerator)
        {
            this.optionsCount = optionsCount;
            this.optionsGenerator = optionsGenerator;
        }

        public Question Generate()
        {
            var id = _questionId++;
            return new Question
            {
                Id = id,
                Title = "question " + id,
                Type = _questionId % 4 == 0 ? QuestionType.Check : QuestionType.Radio,
                Options = Enumerable.Range(0, optionsCount)
                    .Select(index =>
                    {
                        var opt = optionsGenerator.Generate();
                        opt.QuestionId = id;
                        return opt;
                    }).ToList(),
            };
        }

    }
}