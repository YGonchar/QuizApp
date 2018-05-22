using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using QuizApp.Core.Models;

namespace QuizApp.Core.Services
{
    class RealTestService : ITestService
    {
        public Task<IEnumerable<Option>> GetOptions(int optionId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Question>> GetQuestions(int testId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Test>> GetTests()
        {
            throw new NotImplementedException();
        }
    }
}
