using QuizApp.Core.Models;
using System.Linq;

namespace QuizApp.DataGenerator
{
    class TestGenerator : IGenerator<Test>
    {
        private readonly int questionsCount;
        private readonly IGenerator<Question> questionsGenerator;

        private int _testId;
        private string _testName = "Test name";

        public TestGenerator(int questionsCount, IGenerator<Question> questionsGenerator)
        {
            this.questionsCount = questionsCount;
            this.questionsGenerator = questionsGenerator;
        }

        public Test Generate()
        {
            return new Test
            {
                Id = _testId++,
                Name = _testName + _testId,
                Questions = Enumerable.Range(0, questionsCount)
                    .Select(index => questionsGenerator.Generate()),
            };
        }
    }
}
