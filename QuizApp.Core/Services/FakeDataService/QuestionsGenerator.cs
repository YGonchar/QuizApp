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
            return new Question
            {
                Id = _questionId++,
                Options = Enumerable.Range(0, optionsCount)
                    .Select(index =>
                    {
                        var opt = optionsGenerator.Generate();
                        opt.QuestionId = _questionId;
                        return opt;
                    }),
            };
        }
    }
}