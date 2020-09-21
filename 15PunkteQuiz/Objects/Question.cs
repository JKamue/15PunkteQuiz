using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15PunkteQuiz.Objects
{
    class Question
    {
        public readonly string Title;
        public readonly int Difficulty;
        private readonly ImmutableList<string> Answers;

        private readonly string _rightAnswer;
        private readonly ImmutableList<string> _wrongAnswers;
        private readonly int _rightAnswerNumber;

        public Question(string title, int difficulty, string rightAnswer, ImmutableList<string> wrongAnswers)
        {
            Title = title;
            Difficulty = difficulty;
            _rightAnswer = rightAnswer;
            _wrongAnswers = wrongAnswers;

            var rand = new Random();
            _rightAnswerNumber = rand.Next(0, 4);
            Answers = _wrongAnswers.Insert(_rightAnswerNumber, _rightAnswer);
        }

        public bool AnswerWasRight(int num)
        {
            return (num == _rightAnswerNumber);
        }
    }
}
