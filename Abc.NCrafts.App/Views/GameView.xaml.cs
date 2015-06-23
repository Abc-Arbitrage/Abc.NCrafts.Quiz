using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using Abc.NCrafts.App.ViewModels;
using Abc.NCrafts.App.ViewModels.Questions;

namespace Abc.NCrafts.App.Views
{
    /// <summary>
    ///     Interaction logic for GameView.xaml
    /// </summary>
    public partial class GameView : UserControl
    {
        public GameView()
        {
            InitializeComponent();
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            Focusable = true;
            Keyboard.Focus(this);
        }

        private void LoadContent(object sender, RoutedEventArgs e)
        {
            var htmlHelpContent = ((GamePage)DataContext).HtmlHelpContent;
            ((WebBrowser)sender).NavigateToString(htmlHelpContent);
        }

        private void OnWebBrowserLoaded(object sender, NavigationEventArgs e)
        {
            var script = "document.body.style.overflow ='hidden'";
            var wb = (WebBrowser)sender;
            wb.InvokeScript("execScript", script, "JavaScript");
        }

        private void HtmlHelpClick(object sender, MouseButtonEventArgs e)
        {
            var pagePage = (GamePage)DataContext;
            pagePage.IsHelpVisible = false;
        }
    }
}