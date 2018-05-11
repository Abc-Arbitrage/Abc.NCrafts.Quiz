using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Abc.NCrafts.App.ViewModels.Questions;
using ICSharpCode.AvalonEdit.Highlighting;

namespace Abc.NCrafts.App.ViewModels
{
    public class PerformanceGamePage : ViewModel, INotifyPropertyChanged
    {
        private IHighlightingDefinition _syntaxHighlighting;

        public PerformanceGamePage(MainViewModel mainViewModel)
            : base(mainViewModel)
        {
        }

        public bool IsHelpVisible { get; set; }

        private Quiz Quiz => MainViewModel.Quiz;

        public string Answer1Text => Quiz.CurrentQuestion.Answer1.Text;

        public string Answer2Text => Quiz.CurrentQuestion.Answer2.Text;

        public int[] Answer1HighlightedLines => GetHighlightedLines(Quiz.CurrentQuestion.Answer1);

        public int[] Answer2HighlightedLines => GetHighlightedLines(Quiz.CurrentQuestion.Answer2);

        public ICommand Answer1Click
        {
            get { return new ActionCommand(() => SelectAnswer(Quiz.CurrentQuestion.Answer1)); }
        }

        public ICommand Answer2Click
        {
            get { return new ActionCommand(() => SelectAnswer(Quiz.CurrentQuestion.Answer2)); }
        }

        private void SelectAnswer(Answer answer)
        {
            Quiz.CurrentQuestion.SelectedAnswer = answer;

            var canContinue = Quiz.MoveToNextQuestion();

            if (!canContinue)
            {
                GoToNext();
                return;
            }

            OnPropertyChanged();
        }

        private static int[] GetHighlightedLines(Answer answer)
        {
            var lineCount = answer.HighlightedSectionEndIndex - answer.HighlightedSectionBeginIndex + 1;
            return Enumerable.Range(answer.HighlightedSectionBeginIndex + 1, lineCount).ToArray();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public IHighlightingDefinition SyntaxHighlighting => _syntaxHighlighting ?? (_syntaxHighlighting = SyntaxHighLightingLoader.LoadHighlightingDefinition());

        public int QuestionNumber => Quiz.CurrentQuestionIndex + 1;

        public ICommand NavigateForwardCommand => new ActionCommand(NavigateForward);

        public ICommand NavigateBackwardCommand => new ActionCommand(NavigateBackward);

        public ICommand ShowHelpContentCommand => new ActionCommand(ShowHelpContent);

        public string HtmlHelpContent => MainViewModel.Quiz.CurrentQuestion.HtmlHelpContent;

        public ICommand CloseHelp
        {
            get { return new ActionCommand(() => IsHelpVisible = false); }
        }

        public bool IsEasyQuestion => MainViewModel.Quiz.CurrentQuestion.Difficulty >= QuestionDifficulty.Easy;
        public bool IsMediumQuestion => MainViewModel.Quiz.CurrentQuestion.Difficulty >= QuestionDifficulty.Medium;
        public bool IsHardQuestion => MainViewModel.Quiz.CurrentQuestion.Difficulty >= QuestionDifficulty.Hard;

        private void ShowHelpContent()
        {
            IsHelpVisible = true;
        }

        private void NavigateForward()
        {
            Quiz.NavigateForward();

            OnPropertyChanged();
        }

        private void NavigateBackward()
        {
            Quiz.NavigateBackward();

            OnPropertyChanged();
        }

      
    }
}
