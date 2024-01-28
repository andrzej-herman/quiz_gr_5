using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Game
    {
        public Game()
        {
            Random = new Random();
            CreateQuestions();
            AllCategories = Questions.Select(x => x.Category).Distinct().OrderBy(x => x).ToList();
            CurrentCategory = AllCategories[CurrentCategoryIndex];
        }


        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }
        public int PlayerPoints { get; set; }
        public List<int> AllCategories { get; set; }
        public int CurrentCategoryIndex { get; set; }

        public void CreateQuestions()
        {
            Questions = QuestionCreator.CreateQuestions();
        }

        public void DrawQuestion()
        {
            var questionsFromCategory = Questions.Where(x => x.Category == CurrentCategory).ToList();
            var number = Random.Next(0, questionsFromCategory.Count);
            var question = questionsFromCategory[number];
            question.Answers = question.Answers.OrderBy(x => Random.Next()).ToList();

            for (int i = 0; i < question.Answers.Count; i++)
            {
                question.Answers[i].DisplayOrder = i + 1;
            }

            CurrentQuestion = question;
        }

        public bool IsAnswerCorrect(int playerAnswerId)
        {
            var playerAnswer = CurrentQuestion.Answers.FirstOrDefault(x => x.DisplayOrder == playerAnswerId);
            var isCorrect = playerAnswer.IsCorrect;
            if (isCorrect)
            {
                PlayerPoints += CurrentQuestion.Category;
            }

            return isCorrect;
        }

        public bool CheckIfLastQuestion()
        {
            if (CurrentCategoryIndex >= AllCategories.Count - 1)
                return true;
            else
            {
                CurrentCategoryIndex++;
                CurrentCategory = AllCategories[CurrentCategoryIndex];
                return false;
            }
        }


    }
}
