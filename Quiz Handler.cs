using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizApp
{
    public class QuizHandler
    {
        private List<User> users = new List<User>();  
        private Question[] questions;

        public QuizHandler(Question[] questions)
        {
            this.questions = questions;
        }

        
        public User CreateUser()
        {
            Random random = new Random();
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            User user = new User(name, password, random);
            users.Add(user);  
            Console.WriteLine("User created successfully");
            return user;
        }

        
        public void DisplayLeaderBoard()
        {
            Console.Clear();
            Console.WriteLine("===== Leaderboard =====");
            Console.WriteLine("| Rank |   Name   | Score |");
            Console.WriteLine("===========================");

            var sortedUsers = users.OrderByDescending(u => u.Score).ToList();
            for (int i = 0; i < sortedUsers.Count; i++)
            {
                Console.WriteLine($"|  {i + 1,-4} | {sortedUsers[i].Name,-8} | {sortedUsers[i].Score,-6} |");
            }

            Console.WriteLine("===========================");
        }

        
        public void StartQuiz(User user)
        {
            Quiz quiz = new Quiz(questions);
            quiz.StartQuiz(questions);
            user.Score = quiz.Score;  
        }

        
        public void ShowMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("===== Quiz App Menu =====");
                Console.WriteLine("1. Create User");
                Console.WriteLine("2. Start Quiz");
                Console.WriteLine("3. Show Leaderboard");
                Console.WriteLine("4. Exit");
                Console.Write("\nSelect an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        CreateUser();
                        break;

                    case "2":
                        if (users.Count == 0)
                        {
                            Console.WriteLine("No users available. Please create a user first.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("Enter your name to start the quiz: ");
                            string name = Console.ReadLine();
                            User user = users.FirstOrDefault(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                            if (user != null)
                            {
                                StartQuiz(user);
                                Console.WriteLine("Quiz finished. Press any key to continue...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("User not found. Please create the user first.");
                                Console.ReadKey();
                            }
                        }
                        break;

                    case "3":
                        DisplayLeaderBoard();
                        Console.WriteLine("Press any key to go back to the menu...");
                        Console.ReadKey();
                        break;

                    case "4":
                        exit = true;  
                        break;

                    default:
                        Console.WriteLine("Invalid option! Please try again.");
                        break;
                }
            }
        }
    }
}
