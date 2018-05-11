using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using Abc.NCrafts.App.ViewModels;

namespace Abc.NCrafts.App.Views
{
    /// <summary>
    ///     Interaction logic for GameView.xaml
    /// </summary>
    public partial class Performance2018GameView : UserControl
    {
        public Performance2018GameView()
        {
            InitializeComponent();
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            Focusable = true;
            Keyboard.Focus(this);
        }

        private void OnWebBrowserLoaded(object sender, NavigationEventArgs e)
        {
            var script = "document.body.style.overflow ='hidden'";
            var wb = (WebBrowser)sender;
            wb.InvokeScript("execScript", script, "JavaScript");
        }

        private void HtmlHelpClick(object sender, MouseButtonEventArgs e)
        {
            var pagePage = (PerformanceGamePage)DataContext;
            pagePage.IsHelpVisible = false;
        }

        private void OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext == null)
                return;

            var htmlHelpContent = ((Performance2018GamePage)DataContext).HtmlHelpContent;
            _webBrowser.NavigateToString(htmlHelpContent);
        }
    }
}
