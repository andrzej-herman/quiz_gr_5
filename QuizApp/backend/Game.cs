using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.backend
{
    public class Game
    {
        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; } = 100;
        public Question CurrentQuestion { get; set; }

        public void CreateQuestions()
        {
            // pytania z pliku json
            Questions = new List<Question>();
            var q1 = new Question
            {
                Content = "Jak miał na imię Eintein?",
                Category = 100
            };

            var a1 = new Answer();
            a1.Id = 1;
            a1.Content = "Albert";
            a1.IsCorrect = true;
            q1.Answers.Add(a1);

            var a2 = new Answer();
            a2.Id = 2;
            a2.Content = "Adam";
            q1.Answers.Add(a2);

            var a3 = new Answer();
            a3.Id = 3;
            a3.Content = "Tom";
            q1.Answers.Add(a3);

            var a4 = new Answer();
            a4.Id = 4;
            a4.Content = "John";
            q1.Answers.Add(a4);


            var q2 = new Question
            {
                Content = "Jaka jest stolica Polski?",
                Category = 200
            };

            var a5 = new Answer();
            a5.Id = 1;
            a5.Content = "Warszawa";
            a5.IsCorrect = true;
            q2.Answers.Add(a5);

            var a6 = new Answer();
            a6.Id = 2;
            a6.Content = "Łódź";
            q2.Answers.Add(a6);

            var a7 = new Answer();
            a7.Id = 3;
            a7.Content = "Poznań";
            q2.Answers.Add(a7);

            var a8 = new Answer();
            a8.Id = 4;
            a8.Content = "Toruń";
            q2.Answers.Add(a8);

            Questions.Add(q2);

        }

        public void DrawQuestion()
        {
            // prawdziwe losowanie pytania
           CurrentQuestion = Questions[0];
        }

        public bool IsAnswerCorrect(int playerAnswerId)
        {
            var playerAnswer = CurrentQuestion.Answers.FirstOrDefault(x => x.Id == playerAnswerId);
            return playerAnswer.IsCorrect;
        }

    }
}
