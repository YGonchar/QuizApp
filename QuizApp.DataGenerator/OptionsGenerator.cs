using QuizApp.Core.Models;

namespace QuizApp.DataGenerator
{
    public class OptionsGenerator : IGenerator<Option>
    {
        private string _optionValue = "Option";
        private int _optionId;

        public Option Generate()
        {
            return new Option
            {
                Id = _optionId++,
                Value = _optionValue + _optionId,
            };
        }
    }
}