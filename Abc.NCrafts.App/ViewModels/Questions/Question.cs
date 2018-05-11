using System;
using System.Collections.Generic;
using System.Linq;
using MarkdownSharp;

namespace Abc.NCrafts.App.ViewModels.Questions
{
    public class Question
    {
        private static readonly Random _random = new Random();
        private readonly Markdown _markdown = new Markdown();
        private string _htmlHelpContent;

        public List<Answer> Answers { get; }= new List<Answer>();
        public QuestionDifficulty Difficulty { get; set; }
        public Answer SelectedAnswer { get; set; }

        private IEnumerable<Answer> CodeAnswers => Answers.Where(x => x.HasCode);
        private IEnumerable<Answer> NonCodeAnswers => Answers.Where(x => !x.HasCode);

        public Answer Answer1 => CodeAnswers.First();
        public Answer Answer2 => CodeAnswers.Skip(1).First();
        public Answer Answer3 => CodeAnswers.Skip(2).FirstOrDefault() ?? new Answer();
        public Answer NonCodeAnswer => NonCodeAnswers.FirstOrDefault() ?? new Answer();

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
                var randomIndex = _random.Next(index, Answers.Count);
                var tmp = Answers[index];
                Answers[index] = Answers[randomIndex];
                Answers[randomIndex] = tmp;
            }
        }
    }
}