using QuizApp.Core.Models;
using System.Linq;

namespace QuizApp.DataGenerator
{
    class TestGenerator : IGenerator<Test>
    {
        private readonly int questionsCount;
        private readonly IGenerator<Question> questionsGenerator;

        private static int _testId;
        private string _testName = "Тест ";

        public TestGenerator(int questionsCount, IGenerator<Question> questionsGenerator)
        {
            this.questionsCount = questionsCount;
            this.questionsGenerator = questionsGenerator;
        }

        public Test Generate()
        {
            var id = _testId++;
            return new Test
            {
                Id = id,
                Name = _testName + id,
                Questions = Enumerable.Range(0, questionsCount)
                    .Select(index =>
                    {
                        var quest = questionsGenerator.Generate();
                        quest.TestId = id;
                        return quest;
                    }).ToList(),
            };
        }
    }
}
