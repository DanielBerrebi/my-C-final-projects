namespace q2
{
    partial class FormUpdateContent
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
            this.buttonManu = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.radioButtonQuestion0 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonQuestion1 = new System.Windows.Forms.RadioButton();
            this.radioButtonQuestion3 = new System.Windows.Forms.RadioButton();
            this.radioButtonQuestion2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAddInfo = new System.Windows.Forms.RadioButton();
            this.radioButtonAddInfo2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelQuestionTopic = new System.Windows.Forms.Label();
            this.textBoxTopicOrQuestion = new System.Windows.Forms.TextBox();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.textBoxCorrect = new System.Windows.Forms.TextBox();
            this.textBoxWrong1 = new System.Windows.Forms.TextBox();
            this.labelWrong1 = new System.Windows.Forms.Label();
            this.labelWrong2 = new System.Windows.Forms.Label();
            this.labelWrong3 = new System.Windows.Forms.Label();
            this.textBoxWrong2 = new System.Windows.Forms.TextBox();
            this.textBoxWrong3 = new System.Windows.Forms.TextBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.labelContent = new System.Windows.Forms.Label();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.pictureBoxCorrect = new System.Windows.Forms.PictureBox();
            this.pictureBoxWrong1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxWrong2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxWrong3 = new System.Windows.Forms.PictureBox();
            this.buttonUploadWrong1 = new System.Windows.Forms.Button();
            this.buttonUploadWrong2 = new System.Windows.Forms.Button();
            this.buttonUploadWrong3 = new System.Windows.Forms.Button();
            this.labelImage = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWrong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWrong2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWrong3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonManu
            // 
            this.buttonManu.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonManu.Location = new System.Drawing.Point(642, 283);
            this.buttonManu.Name = "buttonManu";
            this.buttonManu.Size = new System.Drawing.Size(131, 23);
            this.buttonManu.TabIndex = 0;
            this.buttonManu.Text = "Go back the manu";
            this.buttonManu.UseVisualStyleBackColor = false;
            this.buttonManu.Click += new System.EventHandler(this.buttonManu_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelUsername.Location = new System.Drawing.Point(32, 18);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(35, 13);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "label1";
            // 
            // radioButtonQuestion0
            // 
            this.radioButtonQuestion0.AutoSize = true;
            this.radioButtonQuestion0.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.radioButtonQuestion0.Location = new System.Drawing.Point(109, 37);
            this.radioButtonQuestion0.Name = "radioButtonQuestion0";
            this.radioButtonQuestion0.Size = new System.Drawing.Size(120, 17);
            this.radioButtonQuestion0.TabIndex = 2;
            this.radioButtonQuestion0.TabStop = true;
            this.radioButtonQuestion0.Text = "True/False question";
            this.radioButtonQuestion0.UseVisualStyleBackColor = false;
            this.radioButtonQuestion0.CheckedChanged += new System.EventHandler(this.radioButtonQuestion0_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(172, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // radioButtonQuestion1
            // 
            this.radioButtonQuestion1.AutoSize = true;
            this.radioButtonQuestion1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.radioButtonQuestion1.Location = new System.Drawing.Point(250, 37);
            this.radioButtonQuestion1.Name = "radioButtonQuestion1";
            this.radioButtonQuestion1.Size = new System.Drawing.Size(126, 17);
            this.radioButtonQuestion1.TabIndex = 4;
            this.radioButtonQuestion1.TabStop = true;
            this.radioButtonQuestion1.Text = "Multi Choice question";
            this.radioButtonQuestion1.UseVisualStyleBackColor = false;
            this.radioButtonQuestion1.CheckedChanged += new System.EventHandler(this.radioButtonQuestion1_CheckedChanged);
            // 
            // radioButtonQuestion3
            // 
            this.radioButtonQuestion3.AutoSize = true;
            this.radioButtonQuestion3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.radioButtonQuestion3.Location = new System.Drawing.Point(589, 37);
            this.radioButtonQuestion3.Name = "radioButtonQuestion3";
            this.radioButtonQuestion3.Size = new System.Drawing.Size(184, 17);
            this.radioButtonQuestion3.TabIndex = 5;
            this.radioButtonQuestion3.TabStop = true;
            this.radioButtonQuestion3.Text = "Multi Choice question with images";
            this.radioButtonQuestion3.UseVisualStyleBackColor = false;
            this.radioButtonQuestion3.CheckedChanged += new System.EventHandler(this.radioButtonQuestion3_CheckedChanged);
            // 
            // radioButtonQuestion2
            // 
            this.radioButtonQuestion2.AutoSize = true;
            this.radioButtonQuestion2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.radioButtonQuestion2.Location = new System.Drawing.Point(392, 37);
            this.radioButtonQuestion2.Name = "radioButtonQuestion2";
            this.radioButtonQuestion2.Size = new System.Drawing.Size(178, 17);
            this.radioButtonQuestion2.TabIndex = 6;
            this.radioButtonQuestion2.TabStop = true;
            this.radioButtonQuestion2.Text = "True/False question with images";
            this.radioButtonQuestion2.UseVisualStyleBackColor = false;
            this.radioButtonQuestion2.CheckedChanged += new System.EventHandler(this.radioButtonQuestion2_CheckedChanged);
            // 
            // radioButtonAddInfo
            // 
            this.radioButtonAddInfo.AutoSize = true;
            this.radioButtonAddInfo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.radioButtonAddInfo.Location = new System.Drawing.Point(109, 72);
            this.radioButtonAddInfo.Name = "radioButtonAddInfo";
            this.radioButtonAddInfo.Size = new System.Drawing.Size(98, 17);
            this.radioButtonAddInfo.TabIndex = 7;
            this.radioButtonAddInfo.TabStop = true;
            this.radioButtonAddInfo.Text = "Add information";
            this.radioButtonAddInfo.UseVisualStyleBackColor = false;
            this.radioButtonAddInfo.CheckedChanged += new System.EventHandler(this.radioButtonAddInfo_CheckedChanged);
            // 
            // radioButtonAddInfo2
            // 
            this.radioButtonAddInfo2.AutoSize = true;
            this.radioButtonAddInfo2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.radioButtonAddInfo2.Location = new System.Drawing.Point(247, 72);
            this.radioButtonAddInfo2.Name = "radioButtonAddInfo2";
            this.radioButtonAddInfo2.Size = new System.Drawing.Size(151, 17);
            this.radioButtonAddInfo2.TabIndex = 8;
            this.radioButtonAddInfo2.TabStop = true;
            this.radioButtonAddInfo2.Text = "Add information with image";
            this.radioButtonAddInfo2.UseVisualStyleBackColor = false;
            this.radioButtonAddInfo2.CheckedChanged += new System.EventHandler(this.radioButtonAddInfo2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add question:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Add information:";
            // 
            // labelQuestionTopic
            // 
            this.labelQuestionTopic.AutoSize = true;
            this.labelQuestionTopic.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelQuestionTopic.Location = new System.Drawing.Point(13, 111);
            this.labelQuestionTopic.Name = "labelQuestionTopic";
            this.labelQuestionTopic.Size = new System.Drawing.Size(14, 13);
            this.labelQuestionTopic.TabIndex = 11;
            this.labelQuestionTopic.Text = "T";
            this.labelQuestionTopic.Visible = false;
            // 
            // textBoxTopicOrQuestion
            // 
            this.textBoxTopicOrQuestion.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxTopicOrQuestion.Location = new System.Drawing.Point(141, 108);
            this.textBoxTopicOrQuestion.Name = "textBoxTopicOrQuestion";
            this.textBoxTopicOrQuestion.Size = new System.Drawing.Size(257, 20);
            this.textBoxTopicOrQuestion.TabIndex = 12;
            this.textBoxTopicOrQuestion.Visible = false;
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelCorrect.Location = new System.Drawing.Point(13, 141);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(81, 13);
            this.labelCorrect.TabIndex = 13;
            this.labelCorrect.Text = "Correct answer:";
            this.labelCorrect.Visible = false;
            // 
            // textBoxCorrect
            // 
            this.textBoxCorrect.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxCorrect.Location = new System.Drawing.Point(141, 138);
            this.textBoxCorrect.Name = "textBoxCorrect";
            this.textBoxCorrect.Size = new System.Drawing.Size(257, 20);
            this.textBoxCorrect.TabIndex = 14;
            this.textBoxCorrect.Visible = false;
            // 
            // textBoxWrong1
            // 
            this.textBoxWrong1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxWrong1.Location = new System.Drawing.Point(531, 138);
            this.textBoxWrong1.Name = "textBoxWrong1";
            this.textBoxWrong1.Size = new System.Drawing.Size(257, 20);
            this.textBoxWrong1.TabIndex = 15;
            this.textBoxWrong1.Visible = false;
            // 
            // labelWrong1
            // 
            this.labelWrong1.AutoSize = true;
            this.labelWrong1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelWrong1.Location = new System.Drawing.Point(404, 141);
            this.labelWrong1.Name = "labelWrong1";
            this.labelWrong1.Size = new System.Drawing.Size(79, 13);
            this.labelWrong1.TabIndex = 16;
            this.labelWrong1.Text = "Wrong answer:";
            this.labelWrong1.Visible = false;
            // 
            // labelWrong2
            // 
            this.labelWrong2.AutoSize = true;
            this.labelWrong2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelWrong2.Location = new System.Drawing.Point(13, 171);
            this.labelWrong2.Name = "labelWrong2";
            this.labelWrong2.Size = new System.Drawing.Size(122, 13);
            this.labelWrong2.TabIndex = 17;
            this.labelWrong2.Text = "Wrong answer2(optinal):";
            this.labelWrong2.Visible = false;
            // 
            // labelWrong3
            // 
            this.labelWrong3.AutoSize = true;
            this.labelWrong3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelWrong3.Location = new System.Drawing.Point(404, 171);
            this.labelWrong3.Name = "labelWrong3";
            this.labelWrong3.Size = new System.Drawing.Size(122, 13);
            this.labelWrong3.TabIndex = 19;
            this.labelWrong3.Text = "Wrong answer3(optinal):";
            this.labelWrong3.Visible = false;
            // 
            // textBoxWrong2
            // 
            this.textBoxWrong2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxWrong2.Location = new System.Drawing.Point(141, 168);
            this.textBoxWrong2.Name = "textBoxWrong2";
            this.textBoxWrong2.Size = new System.Drawing.Size(257, 20);
            this.textBoxWrong2.TabIndex = 20;
            this.textBoxWrong2.Visible = false;
            // 
            // textBoxWrong3
            // 
            this.textBoxWrong3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxWrong3.Location = new System.Drawing.Point(531, 168);
            this.textBoxWrong3.Name = "textBoxWrong3";
            this.textBoxWrong3.Size = new System.Drawing.Size(257, 20);
            this.textBoxWrong3.TabIndex = 21;
            this.textBoxWrong3.Visible = false;
            // 
            // textBoxContent
            // 
            this.textBoxContent.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxContent.Location = new System.Drawing.Point(141, 138);
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(647, 20);
            this.textBoxContent.TabIndex = 22;
            this.textBoxContent.Visible = false;
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelContent.Location = new System.Drawing.Point(13, 141);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(47, 13);
            this.labelContent.TabIndex = 23;
            this.labelContent.Text = "Content:";
            this.labelContent.Visible = false;
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonUploadImage.Location = new System.Drawing.Point(141, 236);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(100, 23);
            this.buttonUploadImage.TabIndex = 24;
            this.buttonUploadImage.Text = "Upload";
            this.buttonUploadImage.UseVisualStyleBackColor = false;
            this.buttonUploadImage.Visible = false;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // pictureBoxCorrect
            // 
            this.pictureBoxCorrect.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pictureBoxCorrect.Location = new System.Drawing.Point(141, 168);
            this.pictureBoxCorrect.Name = "pictureBoxCorrect";
            this.pictureBoxCorrect.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxCorrect.TabIndex = 25;
            this.pictureBoxCorrect.TabStop = false;
            this.pictureBoxCorrect.Visible = false;
            // 
            // pictureBoxWrong1
            // 
            this.pictureBoxWrong1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pictureBoxWrong1.Location = new System.Drawing.Point(286, 168);
            this.pictureBoxWrong1.Name = "pictureBoxWrong1";
            this.pictureBoxWrong1.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxWrong1.TabIndex = 26;
            this.pictureBoxWrong1.TabStop = false;
            this.pictureBoxWrong1.Visible = false;
            // 
            // pictureBoxWrong2
            // 
            this.pictureBoxWrong2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pictureBoxWrong2.Location = new System.Drawing.Point(470, 168);
            this.pictureBoxWrong2.Name = "pictureBoxWrong2";
            this.pictureBoxWrong2.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxWrong2.TabIndex = 27;
            this.pictureBoxWrong2.TabStop = false;
            this.pictureBoxWrong2.Visible = false;
            // 
            // pictureBoxWrong3
            // 
            this.pictureBoxWrong3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pictureBoxWrong3.Location = new System.Drawing.Point(652, 168);
            this.pictureBoxWrong3.Name = "pictureBoxWrong3";
            this.pictureBoxWrong3.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxWrong3.TabIndex = 28;
            this.pictureBoxWrong3.TabStop = false;
            this.pictureBoxWrong3.Visible = false;
            // 
            // buttonUploadWrong1
            // 
            this.buttonUploadWrong1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonUploadWrong1.Location = new System.Drawing.Point(276, 236);
            this.buttonUploadWrong1.Name = "buttonUploadWrong1";
            this.buttonUploadWrong1.Size = new System.Drawing.Size(120, 23);
            this.buttonUploadWrong1.TabIndex = 29;
            this.buttonUploadWrong1.Text = "Upload wrong answer";
            this.buttonUploadWrong1.UseVisualStyleBackColor = false;
            this.buttonUploadWrong1.Visible = false;
            this.buttonUploadWrong1.Click += new System.EventHandler(this.buttonUploadWrong1_Click);
            // 
            // buttonUploadWrong2
            // 
            this.buttonUploadWrong2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonUploadWrong2.Location = new System.Drawing.Point(440, 236);
            this.buttonUploadWrong2.Name = "buttonUploadWrong2";
            this.buttonUploadWrong2.Size = new System.Drawing.Size(159, 23);
            this.buttonUploadWrong2.TabIndex = 30;
            this.buttonUploadWrong2.Text = "Upload wrong answer(optinal)";
            this.buttonUploadWrong2.UseVisualStyleBackColor = false;
            this.buttonUploadWrong2.Visible = false;
            this.buttonUploadWrong2.Click += new System.EventHandler(this.buttonUploadWrong2_Click);
            // 
            // buttonUploadWrong3
            // 
            this.buttonUploadWrong3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonUploadWrong3.Location = new System.Drawing.Point(630, 236);
            this.buttonUploadWrong3.Name = "buttonUploadWrong3";
            this.buttonUploadWrong3.Size = new System.Drawing.Size(158, 23);
            this.buttonUploadWrong3.TabIndex = 31;
            this.buttonUploadWrong3.Text = "Upload wrong answer(optinal)";
            this.buttonUploadWrong3.UseVisualStyleBackColor = false;
            this.buttonUploadWrong3.Visible = false;
            this.buttonUploadWrong3.Click += new System.EventHandler(this.buttonUploadWrong3_Click);
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelImage.Location = new System.Drawing.Point(13, 193);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(39, 13);
            this.labelImage.TabIndex = 32;
            this.labelImage.Text = "Image:";
            this.labelImage.Visible = false;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonOK.Location = new System.Drawing.Point(35, 283);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 33;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Visible = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormUpdateContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.buttonUploadWrong3);
            this.Controls.Add(this.buttonUploadWrong2);
            this.Controls.Add(this.buttonUploadWrong1);
            this.Controls.Add(this.pictureBoxWrong3);
            this.Controls.Add(this.pictureBoxWrong2);
            this.Controls.Add(this.pictureBoxWrong1);
            this.Controls.Add(this.pictureBoxCorrect);
            this.Controls.Add(this.buttonUploadImage);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.textBoxWrong3);
            this.Controls.Add(this.textBoxWrong2);
            this.Controls.Add(this.labelWrong3);
            this.Controls.Add(this.labelWrong2);
            this.Controls.Add(this.labelWrong1);
            this.Controls.Add(this.textBoxWrong1);
            this.Controls.Add(this.textBoxCorrect);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.textBoxTopicOrQuestion);
            this.Controls.Add(this.labelQuestionTopic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonAddInfo2);
            this.Controls.Add(this.radioButtonAddInfo);
            this.Controls.Add(this.radioButtonQuestion2);
            this.Controls.Add(this.radioButtonQuestion3);
            this.Controls.Add(this.radioButtonQuestion1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonQuestion0);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonManu);
            this.Name = "FormUpdateContent";
            this.Text = "UpdateContent";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWrong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWrong2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWrong3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonManu;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.RadioButton radioButtonQuestion0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonQuestion1;
        private System.Windows.Forms.RadioButton radioButtonQuestion3;
        private System.Windows.Forms.RadioButton radioButtonQuestion2;
        private System.Windows.Forms.RadioButton radioButtonAddInfo;
        private System.Windows.Forms.RadioButton radioButtonAddInfo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQuestionTopic;
        private System.Windows.Forms.TextBox textBoxTopicOrQuestion;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.TextBox textBoxCorrect;
        private System.Windows.Forms.TextBox textBoxWrong1;
        private System.Windows.Forms.Label labelWrong1;
        private System.Windows.Forms.Label labelWrong2;
        private System.Windows.Forms.Label labelWrong3;
        private System.Windows.Forms.TextBox textBoxWrong2;
        private System.Windows.Forms.TextBox textBoxWrong3;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.PictureBox pictureBoxCorrect;
        private System.Windows.Forms.PictureBox pictureBoxWrong1;
        private System.Windows.Forms.PictureBox pictureBoxWrong2;
        private System.Windows.Forms.PictureBox pictureBoxWrong3;
        private System.Windows.Forms.Button buttonUploadWrong1;
        private System.Windows.Forms.Button buttonUploadWrong2;
        private System.Windows.Forms.Button buttonUploadWrong3;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Button buttonOK;
    }
}