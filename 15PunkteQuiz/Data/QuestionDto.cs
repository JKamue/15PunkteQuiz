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
        public string Text;
        public int Difficulty;
        public string WrongAnswer1;
        public string WrongAnswer2;
        public string WrongAnswer3;
        public string RightAnswer;

        public QuestionDto(string id, string text, int difficulty, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3, string rightAnswer)
        {
            Id = id;
            Text = text;
            Difficulty = difficulty;
            WrongAnswer1 = wrongAnswer1;
            WrongAnswer2 = wrongAnswer2;
            WrongAnswer3 = wrongAnswer3;
            RightAnswer = rightAnswer;
        }

        public QuestionDto()
        {

        }

        public string DifficultyText()
        {
            var difficulties = new List<string>{"Leicht", "Hart", "Extrem"};
            return difficulties[Difficulty];
        }
    }
}
