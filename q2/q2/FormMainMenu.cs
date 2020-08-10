using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q2
{
    public partial class FormMainMenu : Form
    {
        private string username;
        // showing the player a welcome massage
        public FormMainMenu(string username)
        {
            InitializeComponent();
            this.username = username;
            labelUsername.Text = "Hello " + this.username + " ,Welcome to the Covid-19 Learning place,\nyou can learn from infromation,update content or take a trivia game.\nwhat would you like to do?";
            setBackground();
        }
        private void setBackground()
        {
            Image myimage = new Bitmap("BackgroundImages\\background.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = new Icon("BackgroundImages\\icon.ico");
        }
        //go to a learning form
        private void buttonLearn_Click(object sender, EventArgs e)
        {
            //prevnting the user from opening two windows at the same time
            using (FormLearning learning = new FormLearning(username))
            {
                if (learning.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                }
            }
        }
        //go to a trivia form
        private void buttonTrivia_Click(object sender, EventArgs e)
        {
            using (FormTrivia trivia = new FormTrivia(username))
            {
                if (trivia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                }
            }
        }
        //close the game
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddFactOrQuestion_Click(object sender, EventArgs e)
        {
            //go to a update content form
            using (FormUpdateContent update = new FormUpdateContent(username))
            {
                if (update.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                }
            }
        }
    }
}
