using Quiz;
using QuizApp;
var game = new Game();
Display.DisplayWelcome();

while (true)
{
    game.DrawQuestion();
    var playerAnswerId = Display.DisplayQuestionAndGetAnswer(game.CurrentQuestion);
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