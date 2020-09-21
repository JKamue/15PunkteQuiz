namespace _15PunkteQuiz.Forms
{
    partial class CourseSelection
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(794, 136);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Kursauswahl";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvQuestions
            // 
            this.lvQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvQuestions.GridLines = true;
            this.lvQuestions.HideSelection = false;
            this.lvQuestions.Location = new System.Drawing.Point(101, 138);
            this.lvQuestions.Name = "lvQuestions";
            this.lvQuestions.Size = new System.Drawing.Size(598, 351);
            this.lvQuestions.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvQuestions.TabIndex = 3;
            this.lvQuestions.UseCompatibleStateImageBehavior = false;
            this.lvQuestions.View = System.Windows.Forms.View.Details;
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewQuestion.Location = new System.Drawing.Point(367, 127);
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(225, 37);
            this.btnNewQuestion.TabIndex = 4;
            this.btnNewQuestion.Text = "Hinzufügen";
            this.btnNewQuestion.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(222, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 30);
            this.textBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnNewQuestion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(101, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 184);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neuer Kurs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kursname: ";
            // 
            // lblHelp
            // 
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(624, 720);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(75, 38);
            this.lblHelp.TabIndex = 7;
            this.lblHelp.Text = "Hilfe";
            this.lblHelp.UseVisualStyleBackColor = true;
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // CourseSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 770);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvQuestions);
            this.Controls.Add(this.lblHeading);
            this.Name = "CourseSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wer wird 15 Punkte Schüler?";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ListView lvQuestions;
        private System.Windows.Forms.Button btnNewQuestion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lblHelp;
    }
}