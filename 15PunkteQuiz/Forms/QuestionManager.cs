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
    public partial class QuestionManager : Form
    {
        public QuestionManager()
        {
            InitializeComponent();
            lvQuestions.FullRowSelect = true;
            var item1 = new ListViewItem("item1",0);
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

            for (int i = 0; i < 10; i++)
            {
                ListViewItem item = lvQuestions.Items.Add("Leicht");
                item.Tag = i;
                item.SubItems.Add("Das ist die Frage");
                item.SubItems.Add("Editieren");
                item.SubItems.Add("Löschen");
            }

        }

        private void lvQuestions_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //if (e.IsSelected)
            // e.Item.Selected = false;
        }
        private void DeleteItem(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"you clicked " + e.SubItem.Text);
        }
        private void EditItem(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"you clicked " + e.SubItem.Text);
        }
    }
}
