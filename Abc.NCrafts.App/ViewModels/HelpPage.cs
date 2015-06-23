using Abc.NCrafts.App.ViewModels.Questions;

namespace Abc.NCrafts.App.ViewModels
{
    public class HelpPage
    {
        public Quiz Quiz { get; set; }

        public HelpPage(Quiz quiz)
        {
            Quiz = quiz;
        }
    }
}