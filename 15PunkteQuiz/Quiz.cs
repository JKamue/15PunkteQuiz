using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _15PunkteQuiz
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
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
    }
}
