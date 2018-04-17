using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizApp.Core.Models;
using QuizApp.DataGenerator;

namespace QuizApp.Core.Services
{
    public class MockTestService : ITestService
    {
        private IEnumerable<Test> _tests;
        private IEnumerable<Question> _questions;
        private IEnumerable<Option> _options;

        public MockTestService()
        {
            _tests = MakeFakeData(5);
            _questions = _tests.SelectMany(test => test.Questions);
            _options = _questions.SelectMany(question => question.Options);
        }

        private IEnumerable<Test> MakeFakeData(int testsAmount)
        {
            var randy = new Random();
            for (int i = 0; i < testsAmount; i++)
            {
                yield return new TestGenerator(randy.Next(1, 4)
                    , new QuestionsGenerator(randy.Next(3, 6)
                        , new OptionsGenerator()))
                    .Generate();
            }
        }

        public Task<IEnumerable<Option>> GetOptions(int questionId)
        {
            return Task.FromResult(_options.Where(option => option.QuestionId == questionId));
        }

        public Task<IEnumerable<Question>> GetQuestions(int testId)
        {
            return Task.FromResult(_questions.Where(quest => quest.TestId == testId));
        }

        public Task<IEnumerable<Test>> GetTests()
        {
            return Task.FromResult(_tests);
        }
    }
}
