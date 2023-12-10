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
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($" Pytanie za {question.Category} pkt.");
            Console.WriteLine();
            Console.WriteLine(" " + question.Content);
            Console.WriteLine();
            foreach (var answer in question.Answers)
            {
                Console.WriteLine($" {answer.Id}. {answer.Content}");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Naciśnij 1, 2, 3 lub 4 => ");
            Console.ForegroundColor = ConsoleColor.White;
            // zablkować wpisanie czegokolwiek innego
            return int.Parse(Console.ReadLine());
        }

    }
}
