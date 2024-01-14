using QuizApp.backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.frontend
{
    public static class Display
    {
        public static void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Witaj w Quizie");
            Console.WriteLine(" Odpowiedz na 7 pytań");
            Console.WriteLine(" Powodzenia !!!");
            Console.WriteLine();
            Console.Write(" Nacisnij ENTER, aby rozpocząć grę ... ");
            Console.ReadLine();
        }

        public static int DisplayQuestion(Question question)
        {
            ShowQuestion(question);
            var userInput = Console.ReadLine();
            while (!IsCorrectKey(userInput))
            {
                ShowQuestion(question);
                userInput = Console.ReadLine();
            }

            return int.Parse(userInput); 
        }


        private static void ShowQuestion(Question question)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($" Pytanie za {question.Category} pkt.");
            Console.WriteLine();
            Console.WriteLine(" " + question.Content);
            Console.WriteLine();
            foreach (var answer in question.Answers)
            {
                Console.WriteLine($" {answer.DisplayOrder}. {answer.Content}");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Naciśnij 1, 2, 3 lub 4 => ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static bool IsCorrectKey(string input)
        {
            var correctKeys = new List<string> { "1", "2", "3", "4" };
            return correctKeys.Contains(input);
        }





        public static void DisplayGameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine(" Niestety to nie jest poprawna odpowiedź.");
            Console.WriteLine();
            Console.WriteLine(" KONIEC GRY !!!");
            Console.ReadLine();
        }

        public static void DisplayGoodAnswer(int category)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(" Brawo to jest prawidłowa odpowiedź.");
            Console.WriteLine();
            Console.WriteLine($" Zdobyłeś/aś za to pytanie: {category} pkt.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Nacisnij ENTER, aby przejść do następnego pytania ... ");
            Console.ReadLine();
        }

        public static void DisplaySuccess(int playerPoints)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(" Brawo ukńczyłeś/aś cały Quiz.");
            Console.WriteLine();
            Console.WriteLine($" Zdobyłeś/aś łącznie: {playerPoints} pkt.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

    }
}
