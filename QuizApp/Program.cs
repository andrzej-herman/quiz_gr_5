using QuizApp.backend;
using QuizApp.frontend;
var game = new Game();
game.CreateQuestions();
Display.DisplayWelcome();
var firstQuestion = game.DrawQuestion();

var x = 1;







Console.ReadLine();