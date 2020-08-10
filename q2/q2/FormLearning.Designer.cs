namespace q2
{
    partial class FormLearning
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTopic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.labelImg = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonManu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelUsername.Location = new System.Drawing.Point(42, 53);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(35, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(42, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Topic:";
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelTopic.Location = new System.Drawing.Point(141, 109);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(35, 13);
            this.labelTopic.TabIndex = 2;
            this.labelTopic.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Location = new System.Drawing.Point(42, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Content:";
            // 
            // labelContent
            // 
            this.labelContent.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelContent.Location = new System.Drawing.Point(141, 164);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(500, 50);
            this.labelContent.TabIndex = 4;
            this.labelContent.Text = "label4";
            // 
            // labelImg
            // 
            this.labelImg.AutoSize = true;
            this.labelImg.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelImg.Location = new System.Drawing.Point(42, 259);
            this.labelImg.Name = "labelImg";
            this.labelImg.Size = new System.Drawing.Size(39, 13);
            this.labelImg.TabIndex = 5;
            this.labelImg.Text = "Image:";
            this.labelImg.Visible = false;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(179, 259);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxImage.TabIndex = 6;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Visible = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(144, 370);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(117, 23);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonManu
            // 
            this.buttonManu.Location = new System.Drawing.Point(469, 370);
            this.buttonManu.Name = "buttonManu";
            this.buttonManu.Size = new System.Drawing.Size(117, 23);
            this.buttonManu.TabIndex = 8;
            this.buttonManu.Text = "Go back the manu";
            this.buttonManu.UseVisualStyleBackColor = true;
            this.buttonManu.Click += new System.EventHandler(this.buttonManu_Click);
            // 
            // FormLearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonManu);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelImg);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTopic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsername);
            this.Name = "FormLearning";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label labelImg;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonManu;
    }
}