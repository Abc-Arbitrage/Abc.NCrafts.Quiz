using PropertyChanged;

namespace Abc.NCrafts.App.ViewModels.Questions
{
    [ImplementPropertyChanged]
    public class Answer
    {
        public bool IsCorrect { get; set; }
        public string Text { get; set; }
        public int HighlightedSectionBeginIndex { get; set; }
        public int HighlightedSectionEndIndex { get; set; }
    }
}