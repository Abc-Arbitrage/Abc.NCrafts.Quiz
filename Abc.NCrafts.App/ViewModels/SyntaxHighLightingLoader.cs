using System.Xml;
using Abc.NCrafts.App.Views;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;

namespace Abc.NCrafts.App.ViewModels
{
    public static class SyntaxHighLightingLoader
    {
        public static IHighlightingDefinition LoadHighlightingDefinition()
        {
            var type = typeof(AllocationGameView);
            var fullName = type.Namespace + "." + "CSharpHighlighting.xshd";
            using (var stream = type.Assembly.GetManifestResourceStream(fullName))
            using (var reader = new XmlTextReader(stream))
            {
                return HighlightingLoader.Load(reader, HighlightingManager.Instance);
            }
        }
    }
}