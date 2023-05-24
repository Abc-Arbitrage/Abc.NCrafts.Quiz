using Abc.NCrafts.App.ViewModels.Questions;

namespace Abc.NCrafts.App.ViewModels
{
    public class EndPage : ViewModel
    {
        public EndPage(MainViewModel mainViewModel)
            : base(mainViewModel)
        {
        }

        private Quiz Quiz => MainViewModel.Quiz;

        public string Message => Quiz.IsSuccess
            ? $"""
              Congratulations!
              You correctly answered all {Quiz.Questions.Count} questions!
              """
            : $"""
              Sorry, that's not the right answer.
              {Quiz.CurrentQuestionIndex switch
              {
                  0 => "",
                  1 => "You answered one question correctly.",
                  _ => $"You correctly answered {Quiz.CurrentQuestionIndex} questions out of {Quiz.Questions.Count}."
              }}
              """.Trim();

        public bool CanContinue => Quiz.CurrentQuestion != null;
    }
}
