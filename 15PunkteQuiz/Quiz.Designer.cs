namespace _15PunkteQuiz
{
    partial class Quiz
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bntAnswerA = new System.Windows.Forms.Button();
            this.bntAnswerB = new System.Windows.Forms.Button();
            this.bntAnswerD = new System.Windows.Forms.Button();
            this.bntAnswerC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblProgress);
            this.splitContainer1.Panel1.Controls.Add(this.lblQuestion);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(939, 557);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblProgress
            // 
            this.lblProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProgress.Location = new System.Drawing.Point(0, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(939, 60);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "Frage 1 / 6";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Location = new System.Drawing.Point(0, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(939, 198);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Hier steht die Frage";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bntAnswerA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bntAnswerB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bntAnswerD, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bntAnswerC, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bntAnswerA
            // 
            this.bntAnswerA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntAnswerA.Location = new System.Drawing.Point(15, 3);
            this.bntAnswerA.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.bntAnswerA.Name = "bntAnswerA";
            this.bntAnswerA.Size = new System.Drawing.Size(451, 171);
            this.bntAnswerA.TabIndex = 0;
            this.bntAnswerA.Text = "Antwort A";
            this.bntAnswerA.UseVisualStyleBackColor = true;
            // 
            // bntAnswerB
            // 
            this.bntAnswerB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntAnswerB.Location = new System.Drawing.Point(472, 3);
            this.bntAnswerB.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.bntAnswerB.Name = "bntAnswerB";
            this.bntAnswerB.Size = new System.Drawing.Size(452, 171);
            this.bntAnswerB.TabIndex = 1;
            this.bntAnswerB.Text = "Antwort B";
            this.bntAnswerB.UseVisualStyleBackColor = true;
            // 
            // bntAnswerD
            // 
            this.bntAnswerD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntAnswerD.Location = new System.Drawing.Point(472, 180);
            this.bntAnswerD.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.bntAnswerD.Name = "bntAnswerD";
            this.bntAnswerD.Size = new System.Drawing.Size(452, 160);
            this.bntAnswerD.TabIndex = 2;
            this.bntAnswerD.Text = "Amtwort D";
            this.bntAnswerD.UseVisualStyleBackColor = true;
            // 
            // bntAnswerC
            // 
            this.bntAnswerC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntAnswerC.Location = new System.Drawing.Point(15, 180);
            this.bntAnswerC.Margin = new System.Windows.Forms.Padding(15, 3, 3, 15);
            this.bntAnswerC.Name = "bntAnswerC";
            this.bntAnswerC.Size = new System.Drawing.Size(451, 160);
            this.bntAnswerC.TabIndex = 3;
            this.bntAnswerC.Text = "Antwort C";
            this.bntAnswerC.UseVisualStyleBackColor = true;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 557);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Quiz";
            this.Text = "Wer wird 15 Punkte Schüler?";
            this.ResizeEnd += new System.EventHandler(this.WindowResized);
            this.Resize += new System.EventHandler(this.WindowResized);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bntAnswerA;
        private System.Windows.Forms.Button bntAnswerB;
        private System.Windows.Forms.Button bntAnswerD;
        private System.Windows.Forms.Button bntAnswerC;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblProgress;
    }
}

