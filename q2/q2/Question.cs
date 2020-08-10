using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Question
    {
        protected int questionNumber;
        protected int questionType;
        protected string question;
        protected string correctAnswer;
        protected string [] incorrectAnswer;
        //builder with all the parmeters
        public Question(int questionNumber, int questionType, string question, string correctAnswer, string[] incorrectAnswer)
        {
            this.questionNumber = questionNumber;
            this.questionType = questionType;
            this.question = question;
            this.correctAnswer = correctAnswer;
            this.incorrectAnswer = incorrectAnswer;
        }
        //returning question number
        public int getQuestionNumber()
        {
            return this.questionNumber;
        }
        // returning questiong type
        public int getQuestionType()
        {
            return this.questionType;
        }
        //returning the question
        public string GetQuestion()
        {
            return this.question;
        }
        //returning the correct answer
        public string getCorrectAnswer()
        {
            return this.correctAnswer;
        }
        public void setCorrectAnswer(string str)
        {
            this.correctAnswer=str;
        }
        //returning the incorrect answer/s
        public string[] getIncorrectAnswer()
        {
            return this.incorrectAnswer;
        }
        public string TurnToFormat()
        {
            string str = "" + questionNumber + ";" + questionType + ";" + question + ";" + correctAnswer;
            for (int i = 0; i < incorrectAnswer.Length; i++)
            {
                str += ";" + incorrectAnswer[i];
            }
                return str;
        }
    }
}
