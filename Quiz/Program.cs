using System;
using System.Collections.Generic;

namespace Quiz
{
    public class Quiz
    {
        public Quiz(List<Question> questions)
        {
            this.questions = questions;
        }
        public List<Question> questions { get; set; }
        public int QuestionIndex { get; set; }
        public int Score { get; set; }
        public Question GetQuestion()
        {
            return this.questions[QuestionIndex];
        }
        public void DisplayQuestion()
        {
            var question = this.GetQuestion();
            this.DisplayProgress();
            System.Console.WriteLine($"soru {QuestionIndex + 1}: {question.Text}");
            foreach (var i in question.Choices)
            {
                System.Console.WriteLine($"-{i}");
            }
            System.Console.Write("cevap: ");
            var result = Console.ReadLine();
            this.Guess(result);


        }
        public void Guess(string answer)
        {
            var question = this.GetQuestion();
            if(question.CheckAnswer(answer))
            {
                this.Score++;
            }
            this.QuestionIndex++;
            if (this.questions.Count == this.QuestionIndex)
            {
                this.DisplayScore();
            }
            else
            {
                this.DisplayQuestion();
            }
        }
        public void DisplayScore()
        {
            System.Console.WriteLine($"Score: {this.Score}");
        }

        public void DisplayProgress()
        {
            int TotalQuestion = this.questions.Count;
            int QuestionNumber = this.QuestionIndex+1;
            if(TotalQuestion>=QuestionNumber)
            {
                System.Console.WriteLine($"Question {QuestionNumber} of {TotalQuestion}");
            }
        }
    }
    public class Question
    {
        public Question(string text, string[] choices, string answer)
        {
            this.Text = text;
            this.Choices = choices;
            this.Answer = answer;
        }
        public string Text { get; set; }
        public string[] Choices { get; set; }
        public string Answer { get; set; }
        public bool CheckAnswer(string answer)
        {
            return this.Answer == answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Question("en iyi programlama dili hangisidir?", new string[] { "c#", "python", "java", "go", "ruby" }, "c#");
            var q2 = new Question("en cok kazandıran programlama dili hangisidir?", new string[] { "c#", "python", "java", "go", "ruby" }, "c#");
            var q3 = new Question("en iyi anlasılan programlama dili hangisidir?", new string[] { "c#", "python", "java", "go", "ruby" }, "c#");
            var questions = new List<Question>() { q1, q2, q3 };
            var quiz = new Quiz(questions);
            quiz.DisplayQuestion();
        }
    }
}
