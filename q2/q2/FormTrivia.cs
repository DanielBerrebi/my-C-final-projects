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
using System.Media;

namespace q2
{
    public partial class FormTrivia : Form
    {
        //a counter for move along with the mistakes ArrayList
        private int mistakeCheck = 0;
        //mode 0 is new Game|mode 1 is try the same game again
        private int mode = 0;
        //this is for repeating the question if we are in (try again with the same questions) so we can have the same order of questions
        private int questionCounter = 0;
        private string username;
        private int score;
        const int TIME_FINISH = 30;
        int ticks;
        //saving the 10 questions that was played in the game for a case of play agian with the same questions case 
        private ArrayList triviaQuestions;
        //all the question in the txt
        private ArrayList questions;
        //saving the mistakes so we could show the player what are the correct answers
        private ArrayList mistakes;
        //initializing all the variables
        public FormTrivia(string username)
        {
            this.username = username;
            InitializeComponent();
            setBackground();
            labelUsername.Text = "Hello " + username + " ,Welcome to the Covid-19 Trivia";
            score = 0;
            questions = new ArrayList();
            triviaQuestions = new ArrayList();
            mistakes = new ArrayList();
            readAllQuestions();
            //start the timer
            timer.Start();
            newQuestion();
        }
        private void setBackground()
        {
            Image myimage = new Bitmap("BackgroundImages\\background.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = new Icon("BackgroundImages\\icon.ico");
        }
        //the score on a correct question is 100 points+ 5 points for each secound left on the timer
        public void addScore(int timeLeft)
        {
            score += 100 + timeLeft * 5;
            labelScore.Text = "Score:" + score + "";
        }
        //When the games end we show all the menu buttons that are hidden during the game
        private void gameEnded()
        {
            saveGameScoreToTxt();
            if (score < 1000)
            {
                SoundPlayer simpleSound = new SoundPlayer("Media\\badscore.wav");
                simpleSound.Play();
                MessageBox.Show(username+" you scored "+ score+ " ,you need some practice");

            }
            else if(score<1500)
            {
                SoundPlayer simpleSound = new SoundPlayer("Media\\nicescore.wav");
                simpleSound.Play();
                MessageBox.Show(username + " you scored " + score + " ,you can do better");

            }
            else
            {
                SoundPlayer simpleSound = new SoundPlayer("Media\\goodscore.wav");
                simpleSound.Play();
                MessageBox.Show(username + " you scored " + score + " , well done!!!");
            }
            questionCounter = 0;
            buttonCheckMistakes.Visible = true;
            buttonCheckMistakes.Enabled = true;
            if (mistakes.Count == 0)
            {
                buttonCheckMistakes.Enabled = false;
            }
            buttonCloseGame.Visible = true;
            buttonRepeat.Visible = true;
            buttonNewGame.Visible = true;
            buttonUpdate.Visible = true;
            buttonLearn.Visible = true;
            labelQuestion.Text = "";
            //stop the time and reset it
            timer.Stop();
            ticks = 0;
            clearAllTextAndHidePictures();
        }
        //save the score in a txt and writh in it in the format of :
        //Username : XXXXXX , Score : XXXX
        private void saveGameScoreToTxt()
        {
            string path = "DATA\\outdata_"+ DateTime.Now.ToString("yyyy-MM-ddTHH_mm_ss").ToString() + ".txt";
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("Username : "+username+" , Score :"+score);
            sw.Close();
        }
        //Read all the question from the txt and adding them to the game
        private void readAllQuestions()
        {
            string path = "DATA\\gameData.txt";
            string[] lines = File.ReadAllLines(path);
            Question question;
            string[] arg;
            string[] wrongAnswers;
            for (int i = 0; i < lines.Length; i++)
            {
                arg = lines[i].Split(';');
                //if a game have 1 wrong answer
                if (arg.Length ==5)
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
                question = new Question(int.Parse(arg[0]),int.Parse(arg[1]), arg[2], arg[3], wrongAnswers);
                questions.Add(question);
            }
        }
        private void newQuestion()
        {
            //mode 0 = new game
            if (mode == 0)
            {
            //if the timer reach to zero start it again with the new question
            if(labelTimeLeft.Text == "Time has passed")
            {
                timer.Start();
            }
            ticks = 0;
            //if their are 10 questions already played end the game
            if (triviaQuestions.Count == 10)
            {
                gameEnded();
                return;
            }
            
            Random rnd = new Random();
            bool notused = false;
            int r = 0;
            while (!notused)
            {
                //rand a question from the questions arraylist
                r = rnd.Next(0, questions.Count);
                    //check if the question wasn't played in the correct quiz
                if (!triviaQuestions.Contains(questions[r]))
                {
                    notused = true;
                }
            }
            triviaQuestions.Add(questions[r]);
            setQuestionAndAnswers((Question)questions[r]);
            }
            //mode 1 = its a repeat of the last trivia qustion so we don't need to get new questions
            else
            {
                //check if it is finished
                if(questionCounter == 10)
                {
                    gameEnded();
                    return;
                }
                setQuestionAndAnswers((Question)triviaQuestions[questionCounter]);
                questionCounter++;
            }
        }
        //setting the question and her answers
        private  void setQuestionAndAnswers(Question question)
        {
            labelQuestion.Text = question.GetQuestion();
            Random rnd = new Random();
            int r=0;
            clearAllTextAndHidePictures();
            switch (question.getQuestionType())
            {
                case 0:
                    //random the places of the correct and incorrect answer 
                    r = rnd.Next(0, 2);
                    if (r == 0)
                    {
                        putTextInButtonAnswer1(question.getCorrectAnswer());
                        putTextInButtonAnswer2(question.getIncorrectAnswer()[0]);
                    }
                    else
                    {
                        putTextInButtonAnswer1(question.getIncorrectAnswer()[0]);
                        putTextInButtonAnswer2(question.getCorrectAnswer());
                    }
                    break;
                case 1:
                    //there are only one wrong answer
                    if (question.getIncorrectAnswer().Length == 1)
                    {
                        //random the places of the correct and incorrect answer 
                        r = rnd.Next(0, 2);
                        if (r == 0)
                        {
                            putTextInButtonAnswer1(question.getCorrectAnswer());
                            putTextInButtonAnswer2(question.getIncorrectAnswer()[0]);
                        }
                        else
                        {
                            putTextInButtonAnswer1(question.getIncorrectAnswer()[0]);
                            putTextInButtonAnswer2(question.getCorrectAnswer());
                        }
                    }
                    //there are 2 wrong answers
                    else if (question.getIncorrectAnswer().Length == 2)
                    {
                        //randmize all the 3 answers (include the correct one) in a string array 
                        //every answer get to be in a diffrent index between 0-2 but in randomized place
                        string[] answers = new string[3];
                        r = rnd.Next(0, 3);
                        answers[r]= question.getCorrectAnswer();
                        do
                        {
                            r = rnd.Next(0, 3);
                        }
                        //you can't put the answer in a place that there are answer already in it
                        while (answers[r] != null);
                        answers[r] = question.getIncorrectAnswer()[0];
                        do
                        {
                            r = rnd.Next(0, 3);
                        }
                        while (answers[r] != null);
                        //now copy them to the buttons text
                        answers[r] = question.getIncorrectAnswer()[1];
                        putTextInButtonAnswer1(answers[0]);
                        putTextInButtonAnswer2(answers[1]);
                        putTextInButtonAnswer3(answers[2]);
                    }
                    else
                    {
                        //randmize all the 4 answers (include the correct one) in a string array 
                        //every answer get to be in a diffrent index between 0-3 but in randomized place
                        string[] answers = new string[4];
                        r = rnd.Next(0, 4);
                        answers[r] = question.getCorrectAnswer();
                        do
                        {
                            r = rnd.Next(0, 4);
                        }
                        while (answers[r] != null);
                        answers[r] = question.getIncorrectAnswer()[0];
                        do
                        {
                            r = rnd.Next(0, 4);
                        }
                        while (answers[r] != null);
                        answers[r] = question.getIncorrectAnswer()[1];
                        do
                        {
                            r = rnd.Next(0, 4);
                        }
                        while (answers[r] != null);
                        answers[r] = question.getIncorrectAnswer()[2];
                        putTextInButtonAnswer1(answers[0]);
                        putTextInButtonAnswer2(answers[1]);
                        putTextInButtonAnswer3(answers[2]);
                        putTextInButtonAnswer4(answers[3]);
                    }
                    break;
                case 2:
                    //the same random as in case 0  but with image
                    r = rnd.Next(0, 2);
                    if (r == 0)
                    {
                        pictureBoxAnswer1.Load("QIMAGES\\" + question.getCorrectAnswer());
                        pictureBoxAnswer2.Load("QIMAGES\\" + question.getIncorrectAnswer()[0]);
                    }
                    else
                    {
                        pictureBoxAnswer1.Load("QIMAGES\\" + question.getIncorrectAnswer()[0]);
                        pictureBoxAnswer2.Load("QIMAGES\\" + question.getCorrectAnswer());
                    }
                    resizePicturesAndScreatch();
                    pictureBoxAnswer1.Visible = true;
                    pictureBoxAnswer2.Visible = true;
                    break;
                default:
                    if (question.getIncorrectAnswer().Length == 1)
                    {
                        //the same random as in case 1  but with image
                        r = rnd.Next(0, 2);
                        if (r == 0)
                        {
                            pictureBoxAnswer1.Load("QIMAGES\\" + question.getCorrectAnswer());
                            pictureBoxAnswer2.Load("QIMAGES\\" + question.getIncorrectAnswer()[0]);
                        }
                        else
                        {
                            pictureBoxAnswer1.Load("QIMAGES\\" + question.getIncorrectAnswer()[0]);
                            pictureBoxAnswer2.Load("QIMAGES\\" + question.getCorrectAnswer());
                        }
                        resizePicturesAndScreatch();
                        pictureBoxAnswer1.Visible = true;
                        pictureBoxAnswer2.Visible = true;
                    }
                    else if (question.getIncorrectAnswer().Length == 2)
                    {
                        string[] answers = new string[3];
                        r = rnd.Next(0, 3);
                        answers[r] = question.getCorrectAnswer();
                        do
                        {
                            r = rnd.Next(0, 3);
                        }
                        while (answers[r] != null);
                        answers[r] = question.getIncorrectAnswer()[0];
                        do
                        {
                            r = rnd.Next(0, 3);
                        }
                        while (answers[r] != null);
                        answers[r] = question.getIncorrectAnswer()[1];
                        pictureBoxAnswer1.Load("QIMAGES\\" + answers[0]);
                        pictureBoxAnswer1.Enabled = true;
                        pictureBoxAnswer2.Load("QIMAGES\\" + answers[1]);
                        pictureBoxAnswer3.Load("QIMAGES\\" + answers[2]);
                        resizePicturesAndScreatch();
                        pictureBoxAnswer1.Visible = true;
                        pictureBoxAnswer2.Visible = true;
                        pictureBoxAnswer3.Visible = true;
                    }
                    else
                    {
                        string[] answers = new string[4];
                        r = rnd.Next(0, 4);
                        answers[r] = question.getCorrectAnswer();
                        do
                        {
                            r = rnd.Next(0, 4);
                        }
                        while (answers[r] != null);
                        answers[r] = question.getIncorrectAnswer()[0];
                        do
                        {
                            r = rnd.Next(0, 4);
                        }
                        while (answers[r] != null);
                        answers[r] = question.getIncorrectAnswer()[1];
                        do
                        {
                            r = rnd.Next(0, 4);
                        }
                        while (answers[r] != null);
                        answers[r] = question.getIncorrectAnswer()[2];
                        pictureBoxAnswer1.Load("QIMAGES\\" + answers[0]);
                        pictureBoxAnswer1.Enabled = true;
                        pictureBoxAnswer2.Load("QIMAGES\\" + answers[1]);
                        pictureBoxAnswer3.Load("QIMAGES\\" + answers[2]);
                        pictureBoxAnswer4.Load("QIMAGES\\" + answers[3]);
                        resizePicturesAndScreatch();
                        pictureBoxAnswer1.Visible = true;
                        pictureBoxAnswer2.Visible = true;
                        pictureBoxAnswer3.Visible = true;
                        pictureBoxAnswer4.Visible = true;
                    }
                    break;
            }
        }
        //resize and screach after loading a picture
        private void resizePicturesAndScreatch()
        {
            Size size = new Size(125, 125);
            pictureBoxAnswer1.Size = size;
            pictureBoxAnswer2.Size = size;
            pictureBoxAnswer3.Size = size;
            pictureBoxAnswer4.Size = size;
            pictureBoxAnswer1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAnswer2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAnswer3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAnswer4.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        //copy the input to the button text and make sure the the button is visibale and clickable
        private void putTextInButtonAnswer1(string text)
        {
            buttonAnswer1.Text = text;
            buttonAnswer1.Enabled = true;
            buttonAnswer1.Visible = true;
        }
        private void putTextInButtonAnswer2(string text)
        {
            buttonAnswer2.Text = text;
            buttonAnswer2.Visible = true;
        }
        private void putTextInButtonAnswer3(string text)
        {
            buttonAnswer3.Text = text;
            buttonAnswer3.Visible = true;
        }
        private void putTextInButtonAnswer4(string text)
        {
            buttonAnswer4.Text = text;
            buttonAnswer4.Visible = true;
        }
        //hide and clear all answers visible and their text 
        private void clearAllTextAndHidePictures()
        {
            buttonAnswer1.Visible = false;
            buttonAnswer2.Visible = false;
            buttonAnswer3.Visible = false;
            buttonAnswer4.Visible = false;
            buttonAnswer1.Text = "";
            buttonAnswer2.Text = "";
            buttonAnswer3.Text = "";
            buttonAnswer4.Text = "";
            pictureBoxAnswer1.Visible = false;
            pictureBoxAnswer2.Visible = false;
            pictureBoxAnswer3.Visible = false;
            pictureBoxAnswer4.Visible = false;
            pictureBoxTrue.Visible = false;
        }
        private void pictureBoxAnswer2_Click(object sender, EventArgs e)
        {
            check(pictureBoxAnswer2.ImageLocation);
        }

        private void pictureBoxAnswer1_Click(object sender, EventArgs e)
        {
            check(pictureBoxAnswer1.ImageLocation);
        }

        private void buttonAnswer1_Click(object sender, EventArgs e)
        {
            check(buttonAnswer1.Text);
        }

        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            check(buttonAnswer2.Text);
        }

        private void buttonAnswer3_Click(object sender, EventArgs e)
        {
            check(buttonAnswer3.Text);
        }

        private void buttonAnswer4_Click(object sender, EventArgs e)
        {
            check(buttonAnswer4.Text);
        }

        private void pictureBoxAnswer3_Click(object sender, EventArgs e)
        {
            check(pictureBoxAnswer3.ImageLocation);
        }

        private void pictureBoxAnswer4_Click(object sender, EventArgs e)
        {
            check(pictureBoxAnswer4.ImageLocation);
        }
        //comparing the choosen answer to the correct answer
        private  void check(string text)
        {
            Question quest;
            if (mode == 0)
            {
                quest = (Question)triviaQuestions[triviaQuestions.Count - 1];
            }
            else
            {
                quest = (Question)triviaQuestions[questionCounter - 1];
            }
            //if the question is type 0 or 1 check if the answer is equal to the text
            if (quest.getQuestionType() != 2 && quest.getQuestionType() != 3)
            {
                if (quest.getCorrectAnswer() == text)
                {
                    playCorrect();
                    addScore(30 - ticks);
                    newQuestion();
                }
                else
                {
                    playMistake();
                    mistakes.Add(quest);
                    newQuestion();
                }
            }
            //if question is type 2 or 3  check if the answer+a start of QIMAGES\\ is equal to the url of the question
            else
            {
                string correct = "QIMAGES\\" + quest.getCorrectAnswer();
                if (correct == text)
                {
                    playCorrect();
                    addScore(30 - ticks);
                    newQuestion();

                }
                else
                {
                    playMistake();
                    mistakes.Add(quest);
                    newQuestion();
                }
            }

        }
        //show the player a question that he was wrong and her answer
        private void showWrongs(int i)
        {
            clearAllTextAndHidePictures();
            Question question = (Question)mistakes[i];
            labelQuestion.Text = question.GetQuestion();
            Size size = new Size(125, 125);
            //showing only the right answer and the question and hide all the rest
            switch (question.getQuestionType())
            {
                case 0:
                case 1:
                    putTextInButtonAnswer1(question.getCorrectAnswer());
                    buttonAnswer1.Enabled = false;
                    buttonNextQuestion.Visible = true;
                break;
                case 2:
                default:
                    pictureBoxTrue.Load("QIMAGES\\" + question.getCorrectAnswer());
                    pictureBoxTrue.Visible = true;
                    pictureBoxTrue.Size = size;
                    pictureBoxTrue.SizeMode = PictureBoxSizeMode.StretchImage;
                    buttonNextQuestion.Visible = true;
                    break;
            }
        }
        //a timer that so the time left during the game
        private void timer_Tick(object sender, EventArgs e)
        {
            int time_left = TIME_FINISH - ticks;
            labelTimeLeft.Text = "Time Left:" + time_left + "";
            ticks++;
            if (time_left == 0)
            {
                labelTimeLeft.Text = "Time has passed";
                timer.Stop();
                MessageBox.Show("Times out");
                newQuestion();
            }
        }

        private void buttonCheckMistakes_Click(object sender, EventArgs e)
        {
            showWrongQuestions();
        }
        //start the same trivia question agian
        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            mode = 1;
            mistakeCheck = 0;
            score = 0;
            labelScore.Text = "Score:0";
            mistakes = new ArrayList();
            hideEndGameMenu();
            timer.Start();
            newQuestion();
        }
        //starting a whole new game
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            mode = 0;
            mistakeCheck = 0;
            labelScore.Text = "Score:0";
            score = 0;
            triviaQuestions = new ArrayList();
            mistakes = new ArrayList();
            hideEndGameMenu();
            timer.Start();
            newQuestion();

        }
        //hiding all the menu buttons
        private void hideEndGameMenu()
        {
            buttonCheckMistakes.Visible = false;
            buttonCheckMistakes.Enabled = true;
            buttonCloseGame.Visible = false;
            buttonRepeat.Visible = false;
            buttonNewGame.Visible = false;
            buttonUpdate.Visible = false;
            buttonLearn.Visible = false;
            buttonNextQuestion.Visible = false;
        }
        //opening the learning form
        private void buttonLearn_Click(object sender, EventArgs e)
        {
            Close();
            FormLearning formLearning = new FormLearning(username);
            formLearning.Show();
        }
        //opening the updating form
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Close();
            FormUpdateContent formUpdateContent = new FormUpdateContent(username);
            formUpdateContent.Show();
        }
        //Close the game
        private void buttonCloseGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Show next wrong answer and her correct answer
        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            showWrongQuestions();
        }
        //showing the questiong that the player choose the wrong answer
        private void showWrongQuestions()
        {
            //check if the player watched all his mistakes
            if (mistakeCheck == mistakes.Count)
            {
                clearAllTextAndHidePictures();
                buttonNextQuestion.Visible = false;
                gameEnded();
                mistakeCheck = 0;
                return;
            }
            else
            //show him his mistake
            {
                buttonNextQuestion.Visible = true;
                showWrongs(mistakeCheck);
            }
            mistakeCheck++;
        }
        //play a sound when the play get a wrong answer
        private void playMistake()
        {
            if (triviaQuestions.Count != 10)
            {
                SoundPlayer simpleSound = new SoundPlayer("Media\\wrong.wav");
                simpleSound.Play();
            }

        }
        //play a sound when the play get a correct answer
        private void playCorrect()
        {
            if (triviaQuestions.Count != 10)
            {
                SoundPlayer simpleSound = new SoundPlayer("Media\\correct.wav");
                simpleSound.Play();
            }
        }
    }
}
