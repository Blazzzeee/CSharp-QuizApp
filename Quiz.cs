using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuizApp
{
    internal class Quiz
    {
        private Question[] questions;


        

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }


        private int GetUserChoice()
        {
            Console.WriteLine("Enter choice(number): ");
            string input = Console.ReadLine();
            int choice = 0;

            while (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a proper number!!,Try again !!!!!");
                input = Console.ReadLine();
            }

            return choice - 1;
        }
        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine(question.QuestionText);


            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.Write($" {i + 1}");
                Console.ResetColor();
                Console.Write($" .{question.Answers[i]}");
                Console.WriteLine();


            }


        }

        public void StartQuiz(Question[] questions)
        {
            int score=0;
            int questionNumber = 1;
            Console.WriteLine("Welcome to quiz");
            foreach (Question question in questions)
            {
                Console.WriteLine($"Question.{questionNumber++}");

                DisplayQuestion(question);
                if (GetUserChoice() == question.CorrectAnswerIndex)
                {
                    Console.WriteLine("Correct!");
                    score+=100;
                }
                else
                {
                    Console.WriteLine("Incorrect!!");
                    Console.WriteLine($"The Correct Answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
                Console.WriteLine($"Correct Score: {score}");
            Console.WriteLine("Press any key to continue to next question(s)");
            
            Console.Clear();
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                              Final Score                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();



            double percentage = score / (100.00 * questionNumber);
            Console.WriteLine($"                            Final Score: {score}");
            Console.WriteLine($"                            Percentage:  {percentage*100}");
            if (percentage >= 0.90)
            {
                Console.WriteLine("Excellent job!! You're really mastering this!");
            }
            else if (percentage >= 0.80)
            {
                Console.WriteLine("Very good! You're almost there, keep pushing!");
            }
            else if (percentage >= 0.70)
            {
                Console.WriteLine("Good score! Aim a bit higher next time!!");
            }
            else if (percentage >= 0.60)
            {
                Console.WriteLine("You're getting there, but more practice will help.");
            }
            else if (percentage >= 0.50)
            {
                Console.WriteLine("Almost halfway! Keep practicing, you're improving.");
            }
            else if (percentage >= 0.40)
            {
                Console.WriteLine("Need more improvement, try again and focus.");
            }
            else if (percentage >= 0.30)
            {
                Console.WriteLine("Not quite there, but don't give up! More work is needed.");
            }
            else if (percentage >= 0.20)
            {
                Console.WriteLine("You can do better, let's try again.");
            }
            else if (percentage >= 0.10)
            {
                Console.WriteLine("Very low score, it seems more practice is needed.");
            }
            else if (percentage >= 0.0)
            {
                Console.WriteLine("Uh oh! Your score was too low, Try again!!!!!");
            }
            else
            {
                throw new Exception("Error: Invalid Score Problem");
            }

        }
    }
}

