using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml;
using Abc.NCrafts.App.ViewModels.Questions;
using Abc.NCrafts.App.Views;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;

namespace Abc.NCrafts.App.ViewModels
{
    public class GamePage : ViewModel, INotifyPropertyChanged
    {
        private Answer _selectedAnswer;
        private IHighlightingDefinition _syntaxHighlighting;

        public GamePage(MainViewModel mainViewModel) : base(mainViewModel)
        {
        }

        public bool IsHelpVisible { get; set; }

        private Quiz Quiz
        {
            get { return MainViewModel.Quiz; }
        }

        public string Answer1Text
        {
            get { return Quiz.CurrentQuestion.Answer1.Text; }
        }

        public string Answer2Text
        {
            get { return Quiz.CurrentQuestion.Answer2.Text; }
        }

        public string Answer3Text
        {
            get { return Quiz.CurrentQuestion.Answer3.Text; }
        }

        public int[] Answer1HighlightedLines
        {
            get { return GetHighlightedLines(Quiz.CurrentQuestion.Answer1); }
        }

        public int[] Answer2HighlightedLines
        {
            get { return GetHighlightedLines(Quiz.CurrentQuestion.Answer2); }
        }

        public int[] Answer3HighlightedLines
        {
            get { return GetHighlightedLines(Quiz.CurrentQuestion.Answer3); }
        }

        public ICommand Answer1Click
        {
            get { return new ActionCommand(() => SelectAnswer(Quiz.CurrentQuestion.Answer1)); }
        }

        public ICommand Answer2Click
        {
            get { return new ActionCommand(() => SelectAnswer(Quiz.CurrentQuestion.Answer2)); }
        }

        public ICommand Answer3Click
        {
            get { return new ActionCommand(() => SelectAnswer(Quiz.CurrentQuestion.Answer3)); }
        }

        public Brush Answer1Background
        {
            get { return GetBackground(Quiz.CurrentQuestion.Answer1); }
        }

        public Brush Answer2Background
        {
            get { return GetBackground(Quiz.CurrentQuestion.Answer2); }
        }

        public Brush Answer3Background
        {
            get { return GetBackground(Quiz.CurrentQuestion.Answer3); }
        }

        private void SelectAnswer(Answer answer)
        {
            _selectedAnswer = answer;
            Quiz.CurrentQuestion.SelectedAnswer = answer;

            var canContinue = Quiz.MoveToNextQuestion();
            MainViewModel.UpdateHighScore();

            if (!canContinue)
            {
                GoToNext();
                return;
            }

            OnPropertyChanged();
        }

        private SolidColorBrush GetBackground(Answer answer)
        {
            return new SolidColorBrush(_selectedAnswer == answer ? Colors.PaleGreen : Colors.White);
        }

        private int[] GetHighlightedLines(Answer answer)
        {
            var lineCount = answer.HighlightedSectionEndIndex - answer.HighlightedSectionBeginIndex + 1;
            return Enumerable.Range(answer.HighlightedSectionBeginIndex + 1, lineCount).ToArray();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public IHighlightingDefinition SyntaxHighlighting
        {
            get { return _syntaxHighlighting ?? (_syntaxHighlighting = LoadHighlightingDefinition("CSharpHighlighting.xshd")); }
        }

        public int QuestionNumber
        {
            get { return Quiz.CurrentQuestionIndex + 1; }
        }

        public ICommand NavigateForwardCommand 
        {
            get { return new ActionCommand(NavigateForward); }
        }
        
        public ICommand NavigateBackwardCommand 
        {
            get { return new ActionCommand(NavigateBackward); }
        }

        public ICommand ShowHelpContentCommand
        {
            get { return new ActionCommand(ShowHelpContent); }
        }

        public string HtmlHelpContent
        {
            get { return MainViewModel.Quiz.CurrentQuestion.HtmlHelpContent; }
        }

        public ICommand CloseHelp
        {
            get { return new ActionCommand(() => IsHelpVisible = false); }
        }

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

        public static IHighlightingDefinition LoadHighlightingDefinition(string resourceName)
        {
            var type = typeof(GameView);
            var fullName = type.Namespace + "." + resourceName;
            using (var stream = type.Assembly.GetManifestResourceStream(fullName))
            using (var reader = new XmlTextReader(stream))
            {
                return HighlightingLoader.Load(reader, HighlightingManager.Instance);
            }
        }
    }
}
