namespace q2
{
    partial class FormTrivia
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
            this.components = new System.ComponentModel.Container();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonAnswer1 = new System.Windows.Forms.Button();
            this.buttonAnswer2 = new System.Windows.Forms.Button();
            this.buttonAnswer3 = new System.Windows.Forms.Button();
            this.buttonAnswer4 = new System.Windows.Forms.Button();
            this.pictureBoxAnswer1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAnswer2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAnswer3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAnswer4 = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonRepeat = new System.Windows.Forms.Button();
            this.buttonCheckMistakes = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonLearn = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCloseGame = new System.Windows.Forms.Button();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.pictureBoxTrue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrue)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelUsername.Location = new System.Drawing.Point(62, 30);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(35, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "label1";
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelTimeLeft.Location = new System.Drawing.Point(690, 30);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(54, 13);
            this.labelTimeLeft.TabIndex = 1;
            this.labelTimeLeft.Text = "Time Left:";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelQuestion.Location = new System.Drawing.Point(21, 72);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(52, 13);
            this.labelQuestion.TabIndex = 2;
            this.labelQuestion.Text = "Question:";
            // 
            // buttonAnswer1
            // 
            this.buttonAnswer1.Location = new System.Drawing.Point(8, 102);
            this.buttonAnswer1.Name = "buttonAnswer1";
            this.buttonAnswer1.Size = new System.Drawing.Size(780, 23);
            this.buttonAnswer1.TabIndex = 3;
            this.buttonAnswer1.Text = "button1";
            this.buttonAnswer1.UseVisualStyleBackColor = true;
            this.buttonAnswer1.Visible = false;
            this.buttonAnswer1.Click += new System.EventHandler(this.buttonAnswer1_Click);
            // 
            // buttonAnswer2
            // 
            this.buttonAnswer2.Location = new System.Drawing.Point(8, 148);
            this.buttonAnswer2.Name = "buttonAnswer2";
            this.buttonAnswer2.Size = new System.Drawing.Size(780, 23);
            this.buttonAnswer2.TabIndex = 4;
            this.buttonAnswer2.Text = "button2";
            this.buttonAnswer2.UseVisualStyleBackColor = true;
            this.buttonAnswer2.Visible = false;
            this.buttonAnswer2.Click += new System.EventHandler(this.buttonAnswer2_Click);
            // 
            // buttonAnswer3
            // 
            this.buttonAnswer3.Location = new System.Drawing.Point(8, 191);
            this.buttonAnswer3.Name = "buttonAnswer3";
            this.buttonAnswer3.Size = new System.Drawing.Size(780, 23);
            this.buttonAnswer3.TabIndex = 5;
            this.buttonAnswer3.Text = "button3";
            this.buttonAnswer3.UseVisualStyleBackColor = true;
            this.buttonAnswer3.Visible = false;
            this.buttonAnswer3.Click += new System.EventHandler(this.buttonAnswer3_Click);
            // 
            // buttonAnswer4
            // 
            this.buttonAnswer4.Location = new System.Drawing.Point(8, 233);
            this.buttonAnswer4.Name = "buttonAnswer4";
            this.buttonAnswer4.Size = new System.Drawing.Size(780, 23);
            this.buttonAnswer4.TabIndex = 6;
            this.buttonAnswer4.Text = "button4";
            this.buttonAnswer4.UseVisualStyleBackColor = true;
            this.buttonAnswer4.Visible = false;
            this.buttonAnswer4.Click += new System.EventHandler(this.buttonAnswer4_Click);
            // 
            // pictureBoxAnswer1
            // 
            this.pictureBoxAnswer1.Location = new System.Drawing.Point(221, 102);
            this.pictureBoxAnswer1.Name = "pictureBoxAnswer1";
            this.pictureBoxAnswer1.Size = new System.Drawing.Size(125, 125);
            this.pictureBoxAnswer1.TabIndex = 7;
            this.pictureBoxAnswer1.TabStop = false;
            this.pictureBoxAnswer1.Visible = false;
            this.pictureBoxAnswer1.Click += new System.EventHandler(this.pictureBoxAnswer1_Click);
            // 
            // pictureBoxAnswer2
            // 
            this.pictureBoxAnswer2.Location = new System.Drawing.Point(426, 102);
            this.pictureBoxAnswer2.Name = "pictureBoxAnswer2";
            this.pictureBoxAnswer2.Size = new System.Drawing.Size(125, 125);
            this.pictureBoxAnswer2.TabIndex = 8;
            this.pictureBoxAnswer2.TabStop = false;
            this.pictureBoxAnswer2.Visible = false;
            this.pictureBoxAnswer2.Click += new System.EventHandler(this.pictureBoxAnswer2_Click);
            // 
            // pictureBoxAnswer3
            // 
            this.pictureBoxAnswer3.Location = new System.Drawing.Point(33, 102);
            this.pictureBoxAnswer3.Name = "pictureBoxAnswer3";
            this.pictureBoxAnswer3.Size = new System.Drawing.Size(125, 125);
            this.pictureBoxAnswer3.TabIndex = 9;
            this.pictureBoxAnswer3.TabStop = false;
            this.pictureBoxAnswer3.Visible = false;
            this.pictureBoxAnswer3.Click += new System.EventHandler(this.pictureBoxAnswer3_Click);
            // 
            // pictureBoxAnswer4
            // 
            this.pictureBoxAnswer4.Location = new System.Drawing.Point(619, 102);
            this.pictureBoxAnswer4.Name = "pictureBoxAnswer4";
            this.pictureBoxAnswer4.Size = new System.Drawing.Size(125, 125);
            this.pictureBoxAnswer4.TabIndex = 10;
            this.pictureBoxAnswer4.TabStop = false;
            this.pictureBoxAnswer4.Visible = false;
            this.pictureBoxAnswer4.Click += new System.EventHandler(this.pictureBoxAnswer4_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelScore.Location = new System.Drawing.Point(376, 30);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(44, 13);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "Score:0";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.Location = new System.Drawing.Point(316, 291);
            this.buttonRepeat.Name = "buttonRepeat";
            this.buttonRepeat.Size = new System.Drawing.Size(122, 23);
            this.buttonRepeat.TabIndex = 12;
            this.buttonRepeat.Text = "Repeat Game";
            this.buttonRepeat.UseVisualStyleBackColor = true;
            this.buttonRepeat.Visible = false;
            this.buttonRepeat.Click += new System.EventHandler(this.buttonRepeat_Click);
            // 
            // buttonCheckMistakes
            // 
            this.buttonCheckMistakes.Location = new System.Drawing.Point(36, 291);
            this.buttonCheckMistakes.Name = "buttonCheckMistakes";
            this.buttonCheckMistakes.Size = new System.Drawing.Size(122, 23);
            this.buttonCheckMistakes.TabIndex = 13;
            this.buttonCheckMistakes.Text = "Check mistakes";
            this.buttonCheckMistakes.UseVisualStyleBackColor = true;
            this.buttonCheckMistakes.Visible = false;
            this.buttonCheckMistakes.Click += new System.EventHandler(this.buttonCheckMistakes_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(576, 291);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(122, 23);
            this.buttonNewGame.TabIndex = 14;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Visible = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonLearn
            // 
            this.buttonLearn.Location = new System.Drawing.Point(36, 345);
            this.buttonLearn.Name = "buttonLearn";
            this.buttonLearn.Size = new System.Drawing.Size(122, 23);
            this.buttonLearn.TabIndex = 15;
            this.buttonLearn.Text = "Learn from info";
            this.buttonLearn.UseVisualStyleBackColor = true;
            this.buttonLearn.Visible = false;
            this.buttonLearn.Click += new System.EventHandler(this.buttonLearn_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(316, 345);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(122, 23);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Update Content";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCloseGame
            // 
            this.buttonCloseGame.Location = new System.Drawing.Point(576, 345);
            this.buttonCloseGame.Name = "buttonCloseGame";
            this.buttonCloseGame.Size = new System.Drawing.Size(122, 23);
            this.buttonCloseGame.TabIndex = 17;
            this.buttonCloseGame.Text = "Exit";
            this.buttonCloseGame.UseVisualStyleBackColor = true;
            this.buttonCloseGame.Visible = false;
            this.buttonCloseGame.Click += new System.EventHandler(this.buttonCloseGame_Click);
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Location = new System.Drawing.Point(638, 67);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(106, 23);
            this.buttonNextQuestion.TabIndex = 18;
            this.buttonNextQuestion.Text = "Next Question";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Visible = false;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // pictureBoxTrue
            // 
            this.pictureBoxTrue.Location = new System.Drawing.Point(316, 102);
            this.pictureBoxTrue.Name = "pictureBoxTrue";
            this.pictureBoxTrue.Size = new System.Drawing.Size(125, 125);
            this.pictureBoxTrue.TabIndex = 19;
            this.pictureBoxTrue.TabStop = false;
            this.pictureBoxTrue.Visible = false;
            // 
            // FormTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.pictureBoxTrue);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.buttonCloseGame);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonLearn);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonCheckMistakes);
            this.Controls.Add(this.buttonRepeat);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxAnswer4);
            this.Controls.Add(this.pictureBoxAnswer3);
            this.Controls.Add(this.pictureBoxAnswer2);
            this.Controls.Add(this.pictureBoxAnswer1);
            this.Controls.Add(this.buttonAnswer4);
            this.Controls.Add(this.buttonAnswer3);
            this.Controls.Add(this.buttonAnswer2);
            this.Controls.Add(this.buttonAnswer1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelTimeLeft);
            this.Controls.Add(this.labelUsername);
            this.Name = "FormTrivia";
            this.Text = "Trivia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonAnswer1;
        private System.Windows.Forms.Button buttonAnswer2;
        private System.Windows.Forms.Button buttonAnswer3;
        private System.Windows.Forms.Button buttonAnswer4;
        private System.Windows.Forms.PictureBox pictureBoxAnswer1;
        private System.Windows.Forms.PictureBox pictureBoxAnswer2;
        private System.Windows.Forms.PictureBox pictureBoxAnswer3;
        private System.Windows.Forms.PictureBox pictureBoxAnswer4;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonRepeat;
        private System.Windows.Forms.Button buttonCheckMistakes;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonLearn;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCloseGame;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.PictureBox pictureBoxTrue;
    }
}