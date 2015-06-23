using System.Windows.Input;
using PropertyChanged;

namespace Abc.NCrafts.App
{
    [ImplementPropertyChanged]
    public abstract class ViewModel
    {
        public MainViewModel MainViewModel { get; private set; }

        public ViewModel NextPage { get; set; }

        public ViewModel PreviousPage { get; set; }

        protected ViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            GoToNextCommand = new RelayCommand(delegate { GoToNext(); });
            GoToPreviousCommand = new RelayCommand(delegate { GoToPrevious(); });
        }

        public virtual void GoToNext()
        {
            if (NextPage != null)
                MainViewModel.CurrentPage = NextPage;
        }

        public void GoToPrevious()
        {
            if (PreviousPage != null)
                MainViewModel.CurrentPage = PreviousPage;
        }

        public ICommand GoToNextCommand { get; private set; }

        public ICommand GoToPreviousCommand { get; private set; }
    }
}