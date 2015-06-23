namespace Abc.NCrafts.App.ViewModels
{
    public class RulesPage : ViewModel
    {
        public RulesPage(MainViewModel mainViewModel) : base(mainViewModel)
        {
        }

        public override void GoToNext()
        {
            MainViewModel.StartGame();
            base.GoToNext();
        }
    }
}