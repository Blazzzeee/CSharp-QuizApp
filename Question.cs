using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Question
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string question, string[] answers,int correctAnsIndex)
        {
            QuestionText = question;
            Answers = answers;
            CorrectAnswerIndex = correctAnsIndex;
        }

        public bool ValidateAnswers(int choice)
        {
            return choice == CorrectAnswerIndex;
        }

    }
}
