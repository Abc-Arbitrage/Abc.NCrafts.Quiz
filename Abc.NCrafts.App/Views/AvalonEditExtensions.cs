using System.Linq;
using System.Windows;
using ICSharpCode.AvalonEdit;

namespace Abc.NCrafts.App.Views
{
    public static class AvalonEditExtensions
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.RegisterAttached(
            "Text",
            typeof(string),
            typeof(AvalonEditExtensions),
            new FrameworkPropertyMetadata(default(string), OnTextChanged));

        public static readonly DependencyProperty HighlightedLinesProperty = DependencyProperty.RegisterAttached(
            "HighlightedLines",
            typeof(int[]),
            typeof(AvalonEditExtensions),
            new FrameworkPropertyMetadata(default(int[]), OnHighlightedLinesChanged));

        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var editor = d as TextEditor;
            if (editor == null)
                return;

            editor.Text = e.NewValue as string;
        }

        public static void SetText(DependencyObject element, string value)
        {
            element.SetValue(TextProperty, value);
        }

        public static string GetText(DependencyObject element)
        {
            return (string)element.GetValue(TextProperty);
        }

        private static void OnHighlightedLinesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var editor = d as TextEditor;
            if (editor == null)
                return;

            var highlighter = editor.TextArea.TextView.BackgroundRenderers.OfType<LineHighlighterBackgroundRenderer>().SingleOrDefault();
            if (highlighter == null)
            {
                highlighter = new LineHighlighterBackgroundRenderer();
                editor.TextArea.TextView.BackgroundRenderers.Add(highlighter);
            }

            highlighter.HighlightedLines = e.NewValue as int[];
        }

        public static void SetHighlightedLines(DependencyObject element, string value)
        {
            element.SetValue(HighlightedLinesProperty, value);
        }

        public static int[] GetHighlightedLines(DependencyObject element)
        {
            return (int[])element.GetValue(HighlightedLinesProperty);
        }
    }
}
