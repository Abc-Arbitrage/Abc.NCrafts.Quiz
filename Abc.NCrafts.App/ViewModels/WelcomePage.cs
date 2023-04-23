using System.Windows.Input;

namespace Abc.NCrafts.App.ViewModels
{
    public class WelcomePage : ViewModel
    {
        public WelcomePage(MainViewModel mainViewModel)
            : base(mainViewModel)
        {
        }

        public override void GoToNext()
        {
        }

        public ICommand StartAllocationQuizCommand => new RelayCommand(StartAllocationCommand);
        public ICommand StartPerformance1QuizCommand => new RelayCommand(StartPerformance1Quiz);
        public ICommand StartPerformance2QuizCommand => new RelayCommand(StartPerformance2Quiz);

        private void StartPerformance1Quiz(object obj)
        {
            MainViewModel.StartGame(QuizType.Performance1);
            base.GoToNext();
        }

        private void StartPerformance2Quiz(object obj)
        {
            MainViewModel.StartGame(QuizType.Performance2);
            base.GoToNext();
        }

        private void StartAllocationCommand(object obj)
        {
            MainViewModel.StartGame(QuizType.Allocation);
            base.GoToNext();
        }
    }
}
