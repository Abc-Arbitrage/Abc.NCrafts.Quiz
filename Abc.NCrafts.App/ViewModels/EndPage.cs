namespace Abc.NCrafts.App.ViewModels
{
    public class EndPage : ViewModel
    {
        public EndPage(MainViewModel mainViewModel) : base(mainViewModel)
        {
        }

        public int AnsweredQuestionCount => MainViewModel.Quiz.CurrentQuestionIndex;

        public int Score => MainViewModel.Quiz.CurrentScore;

        public bool CanContinue => MainViewModel.Quiz.CurrentQuestion != null;
    }
}