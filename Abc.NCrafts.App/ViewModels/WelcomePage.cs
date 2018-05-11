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

        public ICommand StartAllocationQuizzCommand => new RelayCommand(StartAllocationCommand);
        public ICommand StartPerformanceQuizzCommand => new RelayCommand(StartPerformanceQuizz);
        public ICommand StartPerformance2018QuizzCommand => new RelayCommand(StartPerformance2018Quizz);

        private void StartPerformanceQuizz(object obj)
        {
            MainViewModel.StartGame(QuizzType.Performance);
            base.GoToNext();
        }

        private void StartPerformance2018Quizz(object obj)
        {
            MainViewModel.StartGame(QuizzType.Performance2018);
            base.GoToNext();
        }

        private void StartAllocationCommand(object obj)
        {
            MainViewModel.StartGame(QuizzType.Allocation);
            base.GoToNext();
        }
    }
}
