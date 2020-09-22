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
    public partial class CourseSelection : Form
    {
        private SqliteDb Db;

        public CourseSelection(SqliteDb db)
        {
            InitializeComponent();
            SetupListView();
            Db = db;

            UpdateCourseList();
        }

        private void SetupListView()
        {
            lvCourses.FullRowSelect = true;
            ListViewExtender extender = new ListViewExtender(lvCourses);
            ListViewButtonColumn playCourseButton = new ListViewButtonColumn(1);
            ListViewButtonColumn editCourseButton = new ListViewButtonColumn(2);
            playCourseButton.Click += EditCourse;
            editCourseButton.Click += PlayCourse;
            playCourseButton.FixedWidth = true;
            editCourseButton.FixedWidth = true;

            lvCourses.Columns.Add("Kursname", 220, HorizontalAlignment.Left);
            lvCourses.Columns.Add("Spielen", 105, HorizontalAlignment.Left);
            lvCourses.Columns.Add("Editieren", 105, HorizontalAlignment.Left);
            extender.AddColumn(playCourseButton);
            extender.AddColumn(editCourseButton);
        }

        private void UpdateCourseList()
        {
            lvCourses.Items.Clear();
            foreach (var course in Db.GetAllCourses())
            {
                ListViewItem item = lvCourses.Items.Add(course.Name);
                item.SubItems.Add("Spielen");
                item.SubItems.Add("Editieren");
                item.Tag = course.Id;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ich bin jederzeit unter mail@jkamue.de zu erreichen falls Sie Probleme haben!","Hilfe");
        }
        private void EditCourse(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"Id: " + e.Item.Tag);
        }
        private void PlayCourse(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"Id: " + e.Item.Tag);
        }

        private void btnNewCourse_Click(object sender, EventArgs e)
        {
            var name = lblNewCourseName.Text;
            var course = new CourseDto(Guid.NewGuid().ToString("N"), name);
            Db.AddCourse(course);
            UpdateCourseList();
        }
    }
}
