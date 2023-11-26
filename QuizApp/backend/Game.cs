using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.backend
{
    public class Game
    {
        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; } = 100;

        public void CreateQuestions()
        {
            Questions = new List<Question>();

            // dwa sposoby

            //var q1 = new Question();
            //q1.Content = "Jak miał na imię Eintein?";
            //q1.Category = 100;
            //q1.Answer_01 = "Albert";
            //q1.Answer_02 = "Adam";
            //q1.Answer_03 = "John";
            //q1.Answer_04 = "Tom";

            var q1 = new Question
            {
                Content = "Jak miał na imię Eintein?",
                Category = 100,
                Answer_01 = "Albert",
                Answer_02 = "Adam",
                Answer_03 = "John",
                Answer_04 = "Tom"
            };

            Questions.Add(q1);

            var q2 = new Question
            {
                Content = "Jaka jest stolica Polski?",
                Category = 200,
                Answer_01 = "Warszawa",
                Answer_02 = "Łódź",
                Answer_03 = "Kraków",
                Answer_04 = "Toruń"
            };

            Questions.Add(q2);

            var q3 = new Question
            {
                Content = "Jaka jest odległość Ziemi od Księżyca?",
                Category = 300,
                Answer_01 = "4678989",
                Answer_02 = "2678000",
                Answer_03 = "6700",
                Answer_04 = "384000"
            };

            Questions.Add(q3);


        }

        public Question DrawQuestion()
        {
            return Questions[0];
        }

    }
}
