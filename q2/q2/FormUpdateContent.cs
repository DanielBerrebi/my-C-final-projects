using System;
using System.Collections;
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
    public partial class FormUpdateContent : Form
    {
        private string username;
        //0=add true/false question|1=add multi choise question|2=add true/false question with pictures|
        //|3=add multi choise question with pictures||4=add infromation|5=add infromation with picture|
        private int mode;
        public FormUpdateContent(string username)
        {
            InitializeComponent();
            setBackground();
            this.username = username;
            labelUsername.Text = "Hello " + this.username + " ,Welcome to the Covid-19 updating content place";
        }
        private void setBackground()
        {
            Image myimage = new Bitmap("BackgroundImages\\background.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = new Icon("BackgroundImages\\icon.ico");
        }
        //hide all the tools and text after an option as changed
        private void hideAllToolsAndClearText()
        {
            //except at the entry of the form he should be visable(start hidden)
            labelQuestionTopic.Visible = true;
            textBoxTopicOrQuestion.Visible = true;
            textBoxTopicOrQuestion.Text = "";
            buttonOK.Visible = true;
            labelCorrect.Visible = false;
            textBoxCorrect.Text = "";
            textBoxCorrect.Visible = false;
            labelWrong1.Visible = false;
            textBoxWrong1.Text = "";
            textBoxWrong1.Visible = false;
            labelWrong2.Visible = false;
            textBoxWrong2.Text = "";
            textBoxWrong2.Visible = false;
            labelWrong3.Visible = false;
            textBoxWrong3.Text = "";
            textBoxWrong3.Visible = false;
            labelContent.Visible = false;
            textBoxContent.Visible = false;
            textBoxContent.Text = "";
            labelImage.Visible = false;
            buttonUploadImage.Visible = false;
            pictureBoxCorrect.Visible = false;
            pictureBoxCorrect.Image = null;
            buttonUploadWrong1.Visible = false;
            pictureBoxWrong1.Visible = false;
            pictureBoxWrong1.Image = null;
            buttonUploadWrong2.Visible = false;
            pictureBoxWrong2.Visible = false;
            pictureBoxWrong2.Image = null;
            buttonUploadWrong3.Visible = false;
            pictureBoxWrong3.Visible = false;
            pictureBoxWrong3.Image = null;
        }
        //showing all the the relevants buttons and text boxes for the type of request
        private void formInterfaceChanger()
        {
            hideAllToolsAndClearText();
            switch (mode)
            {
                case 0:
                    labelQuestionTopic.Text = "Question:";
                    labelCorrect.Visible = true;
                    textBoxCorrect.Visible = true;
                    labelWrong1.Visible = true;
                    textBoxWrong1.Visible = true;
                    break;
                case 1:
                    labelQuestionTopic.Text = "Question:";
                    labelCorrect.Visible = true;
                    textBoxCorrect.Visible = true;
                    labelWrong1.Visible = true;
                    textBoxWrong1.Visible = true;
                    labelWrong2.Visible = true;
                    textBoxWrong2.Visible = true;
                    labelWrong3.Visible = true;
                    textBoxWrong3.Visible = true;
                    break;
                case 2:
                    labelQuestionTopic.Text = "Question:";
                    labelImage.Visible = true;
                    buttonUploadImage.Visible = true;
                    pictureBoxCorrect.Visible = true;
                    buttonUploadWrong1.Visible = true;
                    pictureBoxWrong1.Visible = true;
                    break;
                case 3:
                    labelQuestionTopic.Text = "Question:";
                    labelImage.Visible = true;
                    buttonUploadImage.Visible = true;
                    pictureBoxCorrect.Visible = true;
                    buttonUploadWrong1.Visible = true;
                    pictureBoxWrong1.Visible = true;
                    buttonUploadWrong2.Visible = true;
                    pictureBoxWrong2.Visible = true;
                    buttonUploadWrong3.Visible = true;
                    pictureBoxWrong3.Visible = true;
                    break;
                case 4:
                    labelQuestionTopic.Text = "Topic:";
                    labelContent.Visible = true;
                    textBoxContent.Visible = true;
                    break;
                case 5:
                    labelQuestionTopic.Text = "Topic:";
                    labelContent.Visible = true;
                    textBoxContent.Visible = true;
                    labelImage.Visible = true;
                    buttonUploadImage.Visible = true;
                    pictureBoxCorrect.Visible = true;
                    break;
            }
        }
        private void buttonManu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonQuestion0_CheckedChanged(object sender, EventArgs e)
        {
            mode = 0;
            formInterfaceChanger();
        }

        private void radioButtonQuestion1_CheckedChanged(object sender, EventArgs e)
        {
            mode = 1;
            formInterfaceChanger();
        }

        private void radioButtonQuestion2_CheckedChanged(object sender, EventArgs e)
        {
            mode = 2;
            formInterfaceChanger();
        }

        private void radioButtonQuestion3_CheckedChanged(object sender, EventArgs e)
        {
            mode = 3;
            formInterfaceChanger();
        }

        private void radioButtonAddInfo_CheckedChanged(object sender, EventArgs e)
        {
            mode = 4;
            formInterfaceChanger();
        }

        private void radioButtonAddInfo2_CheckedChanged(object sender, EventArgs e)
        {
            mode = 5;
            formInterfaceChanger();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            checkAllTheParmetersAreFilled();
        }
        //making sure that all the relevant paramters are filled
        //if they are filled adding the question / infromation
        private void checkAllTheParmetersAreFilled()
        {
            string[] incorrect = null;
            switch (mode)
            {
                case 0:
                    if (textBoxTopicOrQuestion.Text.Equals(String.Empty))
                    {
                        MessageBox.Show("Please fill the Question");
                    }
                    else if (!textBoxCorrect.Text.ToLower().Equals("false") && !textBoxCorrect.Text.ToLower().Equals("true"))
                    {
                        MessageBox.Show("The correct answer have to be True or False");
                    }
                    else if (!textBoxWrong1.Text.ToLower().Equals("false") && !textBoxWrong1.Text.ToLower().Equals("true"))
                    {
                        MessageBox.Show("The wrong answer have to be True or False");
                    }
                    else
                    {
                        incorrect = new string[1];
                        incorrect[0] = textBoxWrong1.Text;
                        addQuestion(textBoxTopicOrQuestion.Text, textBoxCorrect.Text, incorrect);
                    }
                    break;
                case 1:

                    if (textBoxTopicOrQuestion.Text.Equals(String.Empty))
                    {
                        MessageBox.Show("Please fill the Question");
                    }
                    else if (textBoxCorrect.Text.Equals(String.Empty))
                    {
                        MessageBox.Show("Please fill the correct answer");
                    }
                    else if (textBoxWrong1.Text.Equals(String.Empty))
                    {
                        MessageBox.Show("Please fill the wrong answer");
                    }
                    else if (textBoxWrong2.Text.Equals(String.Empty) && textBoxWrong3.Text.Equals(String.Empty))
                    {
                        incorrect = new string[1];
                        incorrect[0] = textBoxWrong1.Text;
                        addQuestion(textBoxTopicOrQuestion.Text, textBoxCorrect.Text, incorrect);
                    }
                    else if (textBoxWrong2.Text.Equals(String.Empty) && !textBoxWrong3.Text.Equals(String.Empty))
                    {
                        incorrect = new string[2];
                        incorrect[0] = textBoxWrong1.Text;
                        incorrect[1] = textBoxWrong3.Text;
                        addQuestion(textBoxTopicOrQuestion.Text, textBoxCorrect.Text, incorrect);
                    }
                    else if (!textBoxWrong2.Text.Equals(String.Empty) && textBoxWrong3.Text.Equals(String.Empty))
                    {
                        incorrect = new string[2];
                        incorrect[0] = textBoxWrong1.Text;
                        incorrect[1] = textBoxWrong2.Text;
                        addQuestion(textBoxTopicOrQuestion.Text, textBoxCorrect.Text, incorrect);
                    }
                    else
                    {
                        incorrect = new string[3];
                        incorrect[0] = textBoxWrong1.Text;
                        incorrect[1] = textBoxWrong2.Text;
                        incorrect[2] = textBoxWrong3.Text;
                        addQuestion(textBoxTopicOrQuestion.Text, textBoxCorrect.Text, incorrect);
                    }
                    break;
                case 2:
                    if (textBoxTopicOrQuestion.Text.Equals(String.Empty))
                    {
                        MessageBox.Show("Please fill the Question");
                    }
                    else if (pictureBoxCorrect.Image==null)
                    {
                        MessageBox.Show("Please upload a correct answer picture");
                    }
                    else if (pictureBoxWrong1.Image == null)
                    {
                        MessageBox.Show("Please upload a wrong answer picture");
                    }
                    else
                    {
                        string CorrectPath = pictureBoxCorrect.ImageLocation.ToString();
                        string correct = getPicName(CorrectPath);
                        string wrongPath = pictureBoxWrong1.ImageLocation.ToString();
                        string []wrongs = new string[1];
                        wrongs[0] = getPicName(wrongPath);
                        addQuestion(textBoxTopicOrQuestion.Text, correct, wrongs);
                    }
                    break;
                case 3:
                    if (textBoxTopicOrQuestion.Text.Equals(String.Empty))
                    {
                        MessageBox.Show("Please fill the Question");
                    }
                    else if (pictureBoxCorrect.Image == null)
                    {
                        MessageBox.Show("Please upload a correct answer picture");
                    }
                    else if (pictureBoxWrong1.Image == null)
                    {
                        MessageBox.Show("Please upload a wrong answer picture");
                    }
                    else if (pictureBoxWrong2.Image == null && pictureBoxWrong3.Image == null)
                    {
                        string CorrectPath = pictureBoxCorrect.ImageLocation.ToString();
                        string correct = getPicName(CorrectPath);
                        string wrongPath = pictureBoxWrong1.ImageLocation.ToString();
                        incorrect = new string[1];
                        incorrect[0] = getPicName(wrongPath);
                        addQuestion(textBoxTopicOrQuestion.Text, correct, incorrect);
                    }
                    else if (pictureBoxWrong2.Image == null && pictureBoxWrong3.Image != null)
                    {
                        string CorrectPath = pictureBoxCorrect.ImageLocation.ToString();
                        string correct = getPicName(CorrectPath);
                        string wrongPath = pictureBoxWrong1.ImageLocation.ToString();
                        incorrect = new string[2];
                        incorrect[0] = getPicName(wrongPath);
                        string wrongPath2 = pictureBoxWrong3.ImageLocation.ToString();
                        incorrect[1]= getPicName(wrongPath2);
                        addQuestion(textBoxTopicOrQuestion.Text, correct, incorrect);
                    }
                    else if (pictureBoxWrong2.Image != null && pictureBoxWrong3.Image == null)
                    {
                        string CorrectPath = pictureBoxCorrect.ImageLocation.ToString();
                        string correct = getPicName(CorrectPath);
                        string wrongPath = pictureBoxWrong1.ImageLocation.ToString();
                        incorrect = new string[2];
                        incorrect[0] = getPicName(wrongPath);
                        string wrongPath2 = pictureBoxWrong2.ImageLocation.ToString();
                        incorrect[1] = getPicName(wrongPath2);
                        addQuestion(textBoxTopicOrQuestion.Text, correct, incorrect);
                    }
                    else
                    {
                        string CorrectPath = pictureBoxCorrect.ImageLocation.ToString();
                        string correct = getPicName(CorrectPath);
                        string wrongPath = pictureBoxWrong1.ImageLocation.ToString();
                        incorrect = new string[3];
                        incorrect[0] = getPicName(wrongPath);
                        string wrongPath2 = pictureBoxWrong2.ImageLocation.ToString();
                        incorrect[1] = getPicName(wrongPath2);
                        string wrongPath3 = pictureBoxWrong3.ImageLocation.ToString();
                        incorrect[2] = getPicName(wrongPath3);
                        addQuestion(textBoxTopicOrQuestion.Text, correct, incorrect);
                    }
                    
                    break;
                case 4:
                    if (textBoxTopicOrQuestion.Text.Equals(String.Empty))
                    {
                        MessageBox.Show("Please fill the topic");
                    }
                    else if (textBoxContent.Text.Equals(String.Empty))
                    {
                        MessageBox.Show("Please fill the content");
                    }
                    else
                    {
                        addDataInfo(textBoxTopicOrQuestion.Text, textBoxContent.Text, null);
                    }
                    break;
                case 5:
                    if (textBoxTopicOrQuestion.Text.Equals(String.Empty))
                    {
                        MessageBox.Show("Please fill the topic");
                    }
                    else if (textBoxContent.Text.Equals(String.Empty))
                    {
                        MessageBox.Show("Please fill the content");
                    }
                    else if (pictureBoxCorrect.Image == null)
                    {
                        MessageBox.Show("Please upload a photo");
                    }
                    else
                    {
                        string pathName = pictureBoxCorrect.ImageLocation.ToString();
                        string image = getPicName(pathName);
                        addDataInfo(textBoxTopicOrQuestion.Text, textBoxContent.Text, image);
                    }
                    break;
            }
        }
        //conertion url to picture name
        private string getPicName(string path)
        {
            string[] arg;
            arg = path.Split('\\');
            string name = arg[arg.Length - 1];
            return name;
        }
        //add new question to the txt
        private void addQuestion(string question, string correct, string[] incorrect)
        {
            ArrayList questions = new ArrayList(); ;
            string path = "DATA\\gameData.txt";
            string[] lines = File.ReadAllLines(path);
            Question quest;
            string[] arg;
            string[] wrongAnswers;
            for (int i = 0; i < lines.Length; i++)
            {
                arg = lines[i].Split(';');
                //if a game have 1 wrong answer
                if (arg.Length == 5)
                {
                    wrongAnswers = new string[1];
                    wrongAnswers[0] = arg[4];
                }
                //if a game have 2 wrong answers
                else if (arg.Length == 6)
                {
                    wrongAnswers = new string[2];
                    wrongAnswers[0] = arg[4];
                    wrongAnswers[1] = arg[5];
                }
                else
                {
                    //if a game have 3 wrong answers
                    wrongAnswers = new string[3];
                    wrongAnswers[0] = arg[4];
                    wrongAnswers[1] = arg[5];
                    wrongAnswers[2] = arg[6];
                }
                quest = new Question(int.Parse(arg[0]), int.Parse(arg[1]), arg[2], arg[3], wrongAnswers);
                questions.Add(quest);
            }
            //adding the new question to a arraylist with all the rest of the questions
            //giving the paramter of the arraylist size as the question number
            quest = new Question((questions.Count + 1), mode, question, correct, incorrect);
            questions.Add(quest);
            if (mode == 2)
            {
                //saving the pictures at QIMAGES folder with a start of the question number at the begining of the image name
                pictureBoxCorrect.Image.Save("QIMAGES\\"+ questions.Count +""+ correct);
                pictureBoxWrong1.Image.Save("QIMAGES\\" + questions.Count + "" + incorrect[0]);
                quest.setCorrectAnswer("" + questions.Count + "" + correct);
                incorrect[0] = questions.Count + "" + incorrect[0];
            }
            if (mode == 3)
            {
                //saving the pictures at QIMAGES folder with a start of the question number at the begining of the image name
                pictureBoxCorrect.Image.Save("QIMAGES\\" + questions.Count + "" + correct);
                pictureBoxWrong1.Image.Save("QIMAGES\\" + questions.Count + "" + incorrect[0]);
                quest.setCorrectAnswer(""+questions.Count + "" + correct);
                incorrect[0] = questions.Count + "" + incorrect[0];
                if (incorrect.Length == 2)
                {
                    if (pictureBoxWrong2.Image != null)
                    {
                        pictureBoxWrong2.Image.Save("QIMAGES\\" + questions.Count + "" + incorrect[1]);
                    }
                    else
                    {
                        pictureBoxWrong3.Image.Save("QIMAGES\\" + questions.Count + "" + incorrect[1]);
                    }
                    incorrect[1] = questions.Count + "" + incorrect[1];
                }
                if (incorrect.Length == 3)
                {
                    pictureBoxWrong2.Image.Save("QIMAGES\\" + questions.Count + "" + incorrect[1]);
                    incorrect[1] = questions.Count + "" + incorrect[1];
                    pictureBoxWrong3.Image.Save("QIMAGES\\" + questions.Count + "" + incorrect[2]);
                    incorrect[2] = questions.Count + "" + incorrect[2];
                }
            }
            //saving all the questions details the gameData.txt 
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < questions.Count; i++)
            {
                quest = (Question)questions[i];
                sw.WriteLine(quest.TurnToFormat());
            }
            sw.Close();
            Close();
        }
        //adding a new infromation
        private void addDataInfo(string topic, string content, string image)
        {
            //adding all the infromations to a list
            string path = "DATA\\infoData.txt";
            string[] lines = File.ReadAllLines(path);
            List<DataItem> dataItems=new List<DataItem>();
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
            //the infromation number is equal to the list size + 1
            if (image==null)
            {
                dataItem = new DataItem(dataItems.Count + 1, topic, content);
            }
            else
            {
                dataItem = new DataItem(dataItems.Count + 1, topic, content, image);
            }
            //adding the new infromation to the list
            dataItems.Add(dataItem);
            if (mode == 5)
            {
                pictureBoxCorrect.Image.Save("DIMAGES\\" + dataItems.Count + "" + image);
                dataItem.setImg("" + dataItems.Count + "" + image);
            }
            //saving all the infromation to infoData.txt
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < dataItems.Count; i++)
            {
                dataItem = (DataItem)dataItems[i];
                sw.WriteLine(dataItem.TurnToFormat());
            }
            sw.Close();
            Close();
        }
        //uploading a picture
        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                pictureBoxCorrect.ImageLocation = ofd.FileName;
            pictureBoxCorrect.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        //uploading a picture
        private void buttonUploadWrong1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                pictureBoxWrong1.ImageLocation = ofd.FileName;
            pictureBoxWrong1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        //uploading a picture
        private void buttonUploadWrong2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                pictureBoxWrong2.ImageLocation = ofd.FileName;
            pictureBoxWrong2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        //uploading a picture
        private void buttonUploadWrong3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                pictureBoxWrong3.ImageLocation = ofd.FileName;
            pictureBoxWrong3.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
