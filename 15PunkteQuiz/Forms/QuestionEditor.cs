using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _15PunkteQuiz.Data;

namespace _15PunkteQuiz.Forms
{
    public partial class QuestionEditor : Form
    {
        private readonly IDataSource Db;
        private readonly bool _newQuestion = true;
        private readonly QuestionDto _question;
        private readonly CourseDto _course;

        // Edit existing question
        public QuestionEditor(IDataSource db, CourseDto course, QuestionDto question)
        {
            InitializeComponent();
            Db = db;
            _course = course;
            _newQuestion = false;
            _question = question;
            
            lblQuestion.Text = question.Text;
            lblCorrectAnswer.Text = question.RightAnswer;
            lblWrongAnswer1.Text = question.WrongAnswer1;
            lblWrongAnswer2.Text = question.WrongAnswer2;
            lblWrongAnswer3.Text = question.WrongAnswer3;

            if (question.Difficulty == 2)
                rbtnExtreme.Checked = true;
            if (question.Difficulty == 1)
                rbtnHard.Checked = true;
        }

        // Create new question
        public QuestionEditor(IDataSource db, CourseDto course)
        {
            InitializeComponent();
            Db = db;
            _course = course;
        }

        private void SaveChanges()
        {
            var id = _newQuestion ? Guid.NewGuid().ToString("N") : _question.Id;
            var text = lblQuestion.Text;
            var rightAnswer = lblCorrectAnswer.Text;
            var wrongAnswer1 = lblWrongAnswer1.Text;
            var wrongAnswer2 = lblWrongAnswer2.Text;
            var wrongAnswer3 = lblWrongAnswer3.Text;
            var difficulty = GetDifficulty();

            var question = new QuestionDto(id, text, difficulty, wrongAnswer1, wrongAnswer2, wrongAnswer3, rightAnswer);

            if (_newQuestion)
            {
                Db.AddQuestionToCourse(question, _course);
            }
            else
            {
                Db.EditQuestion(question);
            }

            Close();
        }

        private int GetDifficulty()
        {
            if (rbtnEasy.Checked)
                return 0;

            if (rbtnHard.Checked)
                return 1;

            return 2;
        }

        private void lblSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void lblDiscard_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
