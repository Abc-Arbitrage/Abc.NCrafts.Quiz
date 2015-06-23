using System.Linq;
using System.Windows;
using System.Windows.Media;
using ICSharpCode.AvalonEdit.Rendering;

namespace Abc.NCrafts.App.Views
{
    public class LineHighlighterBackgroundRenderer : IBackgroundRenderer
    {
        public KnownLayer Layer { get { return KnownLayer.Background; } }

        public int[] HighlightedLines { get; set; }

        public void Draw(TextView textView, DrawingContext drawingContext)
        {
            textView.EnsureVisualLines();

            foreach (var lineToHighlight in HighlightedLines.Where(i => textView.Document.LineCount >= i))
            {
                foreach (var rect in BackgroundGeometryBuilder.GetRectsForSegment(textView, textView.Document.GetLineByNumber(lineToHighlight), true))
                {
                    drawingContext.DrawRectangle(new SolidColorBrush(Color.FromArgb(100, 255,184,0)), null, new Rect(rect.Location, new Size(textView.ActualWidth, rect.Height)));
                }
            }
        }
    }
}
