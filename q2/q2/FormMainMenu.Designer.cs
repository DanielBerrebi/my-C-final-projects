namespace q2
{
    partial class FormMainMenu
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonLearn = new System.Windows.Forms.Button();
            this.buttonTrivia = new System.Windows.Forms.Button();
            this.buttonAddFactOrQuestion = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUsername.Location = new System.Drawing.Point(105, 34);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(35, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "label1";
            // 
            // buttonLearn
            // 
            this.buttonLearn.Location = new System.Drawing.Point(158, 76);
            this.buttonLearn.Name = "buttonLearn";
            this.buttonLearn.Size = new System.Drawing.Size(143, 23);
            this.buttonLearn.TabIndex = 1;
            this.buttonLearn.Text = "Learn from facts";
            this.buttonLearn.UseVisualStyleBackColor = true;
            this.buttonLearn.Click += new System.EventHandler(this.buttonLearn_Click);
            // 
            // buttonTrivia
            // 
            this.buttonTrivia.Location = new System.Drawing.Point(158, 139);
            this.buttonTrivia.Name = "buttonTrivia";
            this.buttonTrivia.Size = new System.Drawing.Size(143, 23);
            this.buttonTrivia.TabIndex = 2;
            this.buttonTrivia.Text = "Play trivia";
            this.buttonTrivia.UseVisualStyleBackColor = true;
            this.buttonTrivia.Click += new System.EventHandler(this.buttonTrivia_Click);
            // 
            // buttonAddFactOrQuestion
            // 
            this.buttonAddFactOrQuestion.Location = new System.Drawing.Point(158, 201);
            this.buttonAddFactOrQuestion.Name = "buttonAddFactOrQuestion";
            this.buttonAddFactOrQuestion.Size = new System.Drawing.Size(143, 23);
            this.buttonAddFactOrQuestion.TabIndex = 3;
            this.buttonAddFactOrQuestion.Text = "Update Content";
            this.buttonAddFactOrQuestion.UseVisualStyleBackColor = true;
            this.buttonAddFactOrQuestion.Click += new System.EventHandler(this.buttonAddFactOrQuestion_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(158, 267);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(143, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit Game";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(468, 348);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAddFactOrQuestion);
            this.Controls.Add(this.buttonTrivia);
            this.Controls.Add(this.buttonLearn);
            this.Controls.Add(this.labelUsername);
            this.Name = "FormMainMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonLearn;
        private System.Windows.Forms.Button buttonTrivia;
        private System.Windows.Forms.Button buttonAddFactOrQuestion;
        private System.Windows.Forms.Button buttonExit;
    }
}

