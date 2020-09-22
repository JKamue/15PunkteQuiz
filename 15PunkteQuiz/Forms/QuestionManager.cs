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
using _15PunkteQuiz.Other;

namespace _15PunkteQuiz.Forms
{
    public partial class QuestionManager : Form
    {
        private IDataSource Db;
        private CourseDto Course;

        public QuestionManager(IDataSource db, CourseDto course)
        {
            InitializeComponent();
            SetupListview();
            Db = db;
            Course = course;
            UpdateQuestionList();
        }

        private void SetupListview()
        {
            lvQuestions.FullRowSelect = true;
            var item1 = new ListViewItem("item1", 0);
            ListViewExtender extender = new ListViewExtender(lvQuestions);
            ListViewButtonColumn editItemButton = new ListViewButtonColumn(2);
            ListViewButtonColumn deleteItemButton = new ListViewButtonColumn(3);
            editItemButton.Click += EditItem;
            deleteItemButton.Click += DeleteItem;
            editItemButton.FixedWidth = true;
            deleteItemButton.FixedWidth = true;

            lvQuestions.Columns.Add("Schwierigkeit", 100, HorizontalAlignment.Left);
            lvQuestions.Columns.Add("Frage", 350, HorizontalAlignment.Left);
            lvQuestions.Columns.Add("Editieren", 94, HorizontalAlignment.Center);
            lvQuestions.Columns.Add("Entfernen", 94, HorizontalAlignment.Center);
            extender.AddColumn(editItemButton);
            extender.AddColumn(deleteItemButton);
        }

        private void UpdateQuestionList()
        {
            foreach (var question in Db.GetAllQuestionsByCourse(Course))
            {
                ListViewItem item = lvQuestions.Items.Add(question.DifficultyText());
                item.Tag = question;
                item.SubItems.Add(question.Text);
                item.SubItems.Add("Editieren");
                item.SubItems.Add("Löschen");
            }
        }

        private void DeleteItem(object sender, ListViewColumnMouseEventArgs e)
        {
            var question = (QuestionDto) e.Item.Tag;
            DialogResult dialogResult = MessageBox.Show("Sicher?", $"Soll '{question.Text}' wirklich gelöscht werden?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Db.DeleteQuestion(question);
            }

            UpdateQuestionList();
        }

        private void EditItem(object sender, ListViewColumnMouseEventArgs e)
        {
            var question = (QuestionDto)e.Item.Tag;
            var editItemForm = new QuestionEditor(Db, Course, question);
            Hide();
            editItemForm.ShowDialog();
            Show();
            UpdateQuestionList();
        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            var editItemForm = new QuestionEditor(Db, Course);
            Hide();
            editItemForm.ShowDialog();
            Show();
            UpdateQuestionList();
        }
    }
}
