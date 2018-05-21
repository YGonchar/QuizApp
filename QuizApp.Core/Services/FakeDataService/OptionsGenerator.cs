using QuizApp.Core.Models;

namespace QuizApp.DataGenerator
{
    public class OptionsGenerator : IGenerator<Option>
    {
        private string _optionValue = "Option";
        private static int _optionId;

        public Option Generate()
        {
            var id = _optionId++;
             return new Option
            {
                Id = id,
                Value = _optionValue + _optionId,
            };
        }
    }
}