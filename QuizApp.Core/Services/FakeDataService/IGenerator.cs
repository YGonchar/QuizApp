using QuizApp.Core.Models;

namespace QuizApp.DataGenerator
{
    public interface IGenerator<TModel> where TModel : IModel, new()
    {
        TModel Generate();
    }
}
