namespace _15PunkteQuiz.Forms
{
    partial class QuestionManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.lvQuestions = new System.Windows.Forms.ListView();
            this.btnNewQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(1182, 136);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Fragen verwalten";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvQuestions
            // 
            this.lvQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvQuestions.GridLines = true;
            this.lvQuestions.HideSelection = false;
            this.lvQuestions.Location = new System.Drawing.Point(175, 130);
            this.lvQuestions.Name = "lvQuestions";
            this.lvQuestions.Size = new System.Drawing.Size(850, 560);
            this.lvQuestions.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvQuestions.TabIndex = 1;
            this.lvQuestions.UseCompatibleStateImageBehavior = false;
            this.lvQuestions.View = System.Windows.Forms.View.Details;
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewQuestion.Location = new System.Drawing.Point(868, 723);
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(157, 52);
            this.btnNewQuestion.TabIndex = 2;
            this.btnNewQuestion.Text = "Neue Frage";
            this.btnNewQuestion.UseVisualStyleBackColor = true;
            this.btnNewQuestion.Click += new System.EventHandler(this.btnNewQuestion_Click);
            // 
            // QuestionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.btnNewQuestion);
            this.Controls.Add(this.lvQuestions);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuestionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wer wird 15 Punkte Schüler?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ListView lvQuestions;
        private System.Windows.Forms.Button btnNewQuestion;
    }
}