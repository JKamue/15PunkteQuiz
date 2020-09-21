using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _15PunkteQuiz.Other;

namespace _15PunkteQuiz.Forms
{
    public partial class CourseSelection : Form
    {
        public CourseSelection()
        {
            InitializeComponent();
            lvQuestions.FullRowSelect = true;
            var item1 = new ListViewItem("item1", 0);
            ListViewExtender extender = new ListViewExtender(lvQuestions);
            ListViewButtonColumn editItemButton = new ListViewButtonColumn(1);
            editItemButton.Click += OpenCourse;
            editItemButton.FixedWidth = true;

            lvQuestions.Columns.Add("Kursname", 250, HorizontalAlignment.Left);
            lvQuestions.Columns.Add("Öffnen", 150, HorizontalAlignment.Left);
            extender.AddColumn(editItemButton);

            for (int i = 0; i < 3; i++)
            {
                var kurse = new List<string>{"Biologie", "Chemie", "Was anderes"};
                ListViewItem item = lvQuestions.Items.Add(kurse[i]);
                item.SubItems.Add("Öffnen");
                item.Tag = i;
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ich bin jederzeit unter mail@jkamue.de zu erreichen falls Sie Probleme haben!","Hilfe");
        }
        private void OpenCourse(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"you clicked " + e.SubItem.Text);
        }
    }
}
