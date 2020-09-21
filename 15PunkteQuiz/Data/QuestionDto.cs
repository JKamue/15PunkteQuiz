using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15PunkteQuiz.Data
{
    class QuestionDto
    {
        public string Id;
        public string Title;
        public int Difficulty;
        public List<string> WrongAnswers;
        public string RightAnswer;

        public QuestionDto(string id, string title, int difficulty, List<string> wrongAnswers, string rightAnswer)
        {
            Id = id;
            Title = title;
            Difficulty = difficulty;
            WrongAnswers = wrongAnswers;
            RightAnswer = rightAnswer;
        }
    }
}
