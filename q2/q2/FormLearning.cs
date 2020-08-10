using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q2
{
    public partial class FormLearning : Form
    {
        private string username;
        private List<DataItem> dataItems;
        //inilizing all the variables
        public FormLearning(string username)
        {
            dataItems = new List<DataItem>();
            InitializeComponent();
            setBackground();
            this.username = username;
            labelUsername.Text = "Hello " + this.username + " ,Welcome to the Covid-19 Learning place";
            readInfo();
            setData();
        }
        private void setBackground()
        {
            Image myimage = new Bitmap("BackgroundImages\\background.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = new Icon("BackgroundImages\\icon.ico");
        }
        //reading all the info and adding them to a List of Dataitems
        private void readInfo()
        {
            string path = "DATA\\infoData.txt";
            string[] lines = File.ReadAllLines(path);
            DataItem dataItem;
            string[] arg;
            for (int i = 0; i < lines.Length; i++)
            {
                arg = lines[i].Split(';');
                if (arg.Length > 3)
                {
                    dataItem = new DataItem(int.Parse(arg[0]), arg[1], arg[2], arg[3]);
                }
                else
                {
                    dataItem = new DataItem(int.Parse(arg[0]), arg[1], arg[2]);
                }
                dataItems.Add(dataItem);
            }
        }
        //Showing the topic , content and the image if there are a image
        private void setData()
        {
            //checking if there user saw all the info/facts
           if(dataItems.Count==0)
            {
                MessageBox.Show("You finish to review all the info,\nyou will now go back to the main manu");
                this.Close();
            }
            else
            {
                DataItem data = dataItems[0];
                dataItems.RemoveAt(0);
                // checking if there aren't a image so i will know if to hide the pictureBox and the ImageLabel
                if (data.getImg() == null)
                {
                    labelTopic.Text = data.getTopic();
                    labelContent.Text = data.getContent();
                    pictureBoxImage.Visible = false;
                    labelImg.Visible = false;
                }
                else
                {
                    labelTopic.Text = data.getTopic();
                    labelContent.Text = data.getContent();
                    pictureBoxImage.Visible = true;
                    labelImg.Visible = true;

                    pictureBoxImage.Load("DIMAGES\\" + data.getImg());
                    Size size = new Size(100, 100);
                    pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxImage.Size = size;
                }
            }

        }
        //Move to the next info
        private void buttonNext_Click(object sender, EventArgs e)
        {
            setData();
        }
        //Back to the main menu
        private void buttonManu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
