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

        private void StartPerformanceQuizz(object obj)
        {
            MainViewModel.StartGame(QuizzType.Performance);
            base.GoToNext();
        }

        private void StartAllocationCommand(object obj)
        {
            MainViewModel.StartGame(QuizzType.Allocation);
            base.GoToNext();
        }
    }
}
