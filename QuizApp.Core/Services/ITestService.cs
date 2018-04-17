using QuizApp.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApp.Core.Services
{
    public interface ITestService
    {
        Task<IEnumerable<Test>> GetTests();
        Task<IEnumerable<Question>> GetQuestions(int testId);
        Task<IEnumerable<Option>> GetOptions(int optionId);
    }
}
