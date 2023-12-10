using QuizApp.backend;
using QuizApp.frontend;
var game = new Game();
game.CreateQuestions();
Display.DisplayWelcome();
game.DrawQuestion();
var playerAnswerId = Display.DisplayQuestion(game.CurrentQuestion);
// sprawdzanie czy dopowiedź jest prawidłowa
if (game.IsAnswerCorrect(playerAnswerId))
{
    Console.WriteLine(" BRAWO !!!");
}
else
{
    Console.WriteLine(" GAME OVER !!!");
}



























Console.ReadLine();