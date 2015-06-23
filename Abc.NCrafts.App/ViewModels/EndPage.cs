namespace Abc.NCrafts.App.ViewModels
{
    public class EndPage : ViewModel
    {
        public EndPage(MainViewModel mainViewModel) : base(mainViewModel)
        {
        }

        public int AnsweredQuestionCount
        {
            get
            {
                return MainViewModel.Quiz.CurrentQuestionIndex;
            }
        }

        public int Score { get { return MainViewModel.Quiz.CurrentScore; } }
    }
}