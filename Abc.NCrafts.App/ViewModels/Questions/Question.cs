using System;
using System.Collections.Generic;
using System.Linq;
using MarkdownSharp;

namespace Abc.NCrafts.App.ViewModels.Questions
{
    public class Question
    {
        private readonly Markdown _markdown = new Markdown();
        private string _htmlHelpContent;

        public Question(QuestionLevel level)
        {
            Level = level;
        }

        public QuestionLevel Level { get; }
        public List<Answer> Answers { get; }= new List<Answer>();
        public IReadOnlyCollection<Answer> SelectedAnswers { get; set; } = Array.Empty<Answer>();

        public Answer Answer1 => Answers.FirstOrDefault();
        public Answer Answer2 => Answers.Skip(1).FirstOrDefault();
        public Answer Answer3 => Answers.Skip(2).FirstOrDefault();

        public string MarkdownHelpContent { get; set; }

        public string HtmlHelpContent => _htmlHelpContent ?? (_htmlHelpContent = CreateHtmlHelpContent());

        private string CreateHtmlHelpContent()
        {
            var content = _markdown.Transform(MarkdownHelpContent);
            var css = "code { color: #222; background-color: #EEE; font-family: Consolas; padding: 1 5 1 5; } body { font-family: Helvetica; font-size: 15; line-height: 19.5px; }";
            return $@"<html><style type='text/css'>{css}</style><body>{content}</body></html>";
        }

        public void ShuffleAnswers()
        {
            for (var index = 0; index < Answers.Count - 1; index++)
            {
                var randomIndex = Random.Shared.Next(index, Answers.Count);
                var tmp = Answers[index];
                Answers[index] = Answers[randomIndex];
                Answers[randomIndex] = tmp;
            }
        }

        public bool IsSelectedAnswerValid()
        {
            return Answers.Where(x => x.IsCorrect).All(x => SelectedAnswers.Contains(x));
        }
    }
}