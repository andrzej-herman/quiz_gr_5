using QuizApp.backend;
using QuizApp.frontend;
var game = new Game();
Display.DisplayWelcome();

while (true)
{
    game.DrawQuestion();
    var playerAnswerId = Display.DisplayQuestion(game.CurrentQuestion);
    if (game.IsAnswerCorrect(playerAnswerId))
    {
        if (game.CheckIfLastQuestion())
        {
            Display.DisplaySuccess(game.PlayerPoints);
            break;
        }
        else
        {
            Display.DisplayGoodAnswer(game.CurrentQuestion.Category);

        }
    }
    else
    {
        Display.DisplayGameOver();
        break;
    }
}





























Console.ReadLine();