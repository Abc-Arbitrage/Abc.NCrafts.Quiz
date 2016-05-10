namespace Abc.NCrafts.App.ViewModels
{
    public class WelcomePage : ViewModel
    {
        public WelcomePage(MainViewModel mainViewModel) : base(mainViewModel)
        {
        }

        public override void GoToNext()
        {
            MainViewModel.StartGame();
            base.GoToNext();
        }
    }
}