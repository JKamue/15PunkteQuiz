using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15PunkteQuiz.Objects
{
    public class Question
    {
        public readonly string Title;
        public readonly string Difficulty;
        public readonly ImmutableList<string> Answers;

        private readonly string _rightAnswer;
        private readonly ImmutableList<string> _wrongAnswers;
        private readonly int _rightAnswerNumber;

        public Question(string title, string difficulty, string rightAnswer, ImmutableList<string> wrongAnswers)
        {
            Title = title;
            Difficulty = difficulty;
            _rightAnswer = rightAnswer;
            _wrongAnswers = wrongAnswers;

            var rand = new Random();
            _rightAnswerNumber = rand.Next(0, 4);
            Answers = _wrongAnswers.Insert(_rightAnswerNumber, _rightAnswer);
        }

        public int GetRightAnswer()
        {
            return _rightAnswerNumber;
        }
    }
}
