using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using _15PunkteQuiz.Data;
using _15PunkteQuiz.Objects;

namespace _15PunkteQuiz.Forms
{
    public partial class Quiz : Form
    {
        private int RoundNumber = 0;
        private bool FiftyJoker = true;
        private bool HelpJoker = true;
        private List<string> AskedQuestions = new List<string>();

        private readonly IDataSource Db;
        private readonly CourseDto Course;

        private readonly List<Button> _buttons;
        private Question currentQuestion;
        private int lastAnswer = -1;


        public Quiz(IDataSource db, CourseDto course)
        {
            Db = db;
            Course = course;

            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;

            _buttons = new List<Button>
            {
                bntAnswerA,
                bntAnswerB,
                bntAnswerC,
                bntAnswerD
            };

            DisplayNextQuestion();
        }

        public void DisplayNextQuestion()
        {
            var question = GetNextQuestion();
            DisplayQuestion(question);
        }

        public Question GetNextQuestion()
        {
            RoundNumber++;
            var known = true;
            Question question = null;
            while (known)
            {
                var rndQuestion = Db.GetRandomQuestionByCourse(Course, (int) Math.Floor((double) (RoundNumber-1) / 2));
                if (!AskedQuestions.Contains(rndQuestion.Id))
                {
                    known = false;
                    question = new Question(
                        rndQuestion.Text,
                        rndQuestion.DifficultyText(),
                        rndQuestion.RightAnswer,
                        ImmutableList.Create(
                            rndQuestion.WrongAnswer1, 
                            rndQuestion.WrongAnswer2,
                            rndQuestion.WrongAnswer3)
                        );
                    AskedQuestions.Add(rndQuestion.Id);
                }
            }

            currentQuestion = question;
            return question;
        }

        public void DisplayQuestion(Question question)
        {
            _buttons.ForEach(b => b.BackColor = SystemColors.Control);
            _buttons.ForEach(b => b.FlatAppearance.BorderColor = Color.Black);

            for (var i = 0; i < 4; i++)
            {
                _buttons[i].Text = question.Answers[i];
            }

            lblQuestion.Text = question.Title;
            lblProgress.Text = $"Frage {RoundNumber} / 6 - {question.Difficulty}";

            lastAnswer = -1;
        }

        private void WindowResized(object sender, EventArgs e)
        {
            var size = (float) Math.Sqrt(Width * Width + Height * Height);
            var buttonFont = new Font("Arial", size / 80, FontStyle.Bold);
            lblQuestion.Font = new Font("Arial", size / 50, FontStyle.Bold);
            lblProgress.Font = new Font("Arial", size / 120, FontStyle.Bold);
            bntAnswerA.Font = buttonFont;
            bntAnswerB.Font = buttonFont;
            bntAnswerC.Font = buttonFont;
            bntAnswerD.Font = buttonFont;
            bntAnswerD.Font = buttonFont;
        }

        private async void AnswerButtonClicked(object sender, EventArgs e)
        {
            var num = Int16.Parse(((Control)sender).Tag.ToString());

           _buttons[num].FlatAppearance.BorderColor = Color.Blue;
           var delay = 1000;

            var answers = new List<int>{0,1,2,3};
           answers.Remove(num);
           answers.Remove(currentQuestion.GetRightAnswer());
           answers.OrderBy(x => Guid.NewGuid()).ToList();

           foreach (var answer in answers)
           {
               await Task.Delay(delay);
                _buttons[answer].BackColor = Color.DarkRed;
               delay += 500;
           }


           if (num != currentQuestion.GetRightAnswer())
           {
               await Task.Delay(delay);
                _buttons[num].BackColor = Color.DarkRed;
           }
           await Task.Delay(1000);


           _buttons[currentQuestion.GetRightAnswer()].BackColor = Color.Green;

           lastAnswer = num;
        }

        private void Quiz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 'n')
                return;

            if (lastAnswer == -1)
            {
                RoundNumber--;
                DisplayNextQuestion();
            }
            else
            {
                if (lastAnswer == currentQuestion.GetRightAnswer())
                {
                    if (RoundNumber != 6)
                    {
                        DisplayNextQuestion();
                    }
                    else
                    {
                        MessageBox.Show("Gratulation","Du hast gewonnen!");
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
