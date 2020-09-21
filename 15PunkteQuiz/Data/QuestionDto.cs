using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15PunkteQuiz.Data
{
    public class QuestionDto
    {
        public string Id;
        public string Title;
        public int Difficulty;
        public string WrongAnswer1;
        public string WrongAnswer2;
        public string WrongAnswer3;
        public string RightAnswer;

        public QuestionDto(string id, string title, int difficulty, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3, string rightAnswer)
        {
            Id = id;
            Title = title;
            Difficulty = difficulty;
            WrongAnswer1 = wrongAnswer1;
            WrongAnswer2 = wrongAnswer2;
            WrongAnswer3 = wrongAnswer3;
            RightAnswer = rightAnswer;
        }
    }
}
