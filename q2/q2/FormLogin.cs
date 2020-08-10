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
    public partial class FormLogin : Form
    {
        private string username;
        public FormLogin()
        {
            InitializeComponent();
            setBackground();
        }
        private void setBackground()
        {
            Image myimage = new Bitmap("BackgroundImages\\background.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = new Icon("BackgroundImages\\icon.ico");
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            //make sure he didn't enter null
            if (textBoxUsername.Text.Equals(String.Empty))
            {
                MessageBox.Show("Please fill the Username field");
            }
            else
            {
                //returning a OK so we can know that this form ended well
                this.username = textBoxUsername.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        //return username
        public string getUsername()
        {
            return this.username;
        }
        //allows only letters and digits
        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
