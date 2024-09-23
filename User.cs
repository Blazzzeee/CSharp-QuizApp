using System;
using System.Diagnostics;

namespace QuizApp
{
    public class User
    {
        private static int _counter = 1;  
        private string _name;
        private string _password;
        private int _authKey;
        private int Id;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Score { get; set; }  

        public User(string name, string password, Random random)
        {
            _authKey = random.Next(100000, 1000000);
            Name = name;
            Password = password;
            Id = _counter++;
            Score = 0;
            Console.WriteLine("Remember your authkey as: "+_authKey);
        }

        public string Password
        {
            get
            {
                Console.WriteLine("The user is not allowed to see the password!");
                return "*******";  
            }
            set
            {
                if (value == Name + Id.ToString())
                {
                    Console.WriteLine("Enter authentication key to reset password: ");
                    int authKeyInput = int.Parse(Console.ReadLine());

                    if (authKeyInput == _authKey)
                    {
                        Console.WriteLine("Enter new password: ");
                        _password = Console.ReadLine();
                        Console.WriteLine("Password reset successful.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid authentication key!");
                    }
                }
                else
                {
                    _password = value; 
                }
            }
        }

        
        public int Authenticate(string username, string password)
        {
            if (username == Name && password == _password)
            {
                return 80;  
            }
            else
            {
                Console.WriteLine("Authentication Error!!");
                Debug.Write($"User {Name} tried a login attempt at : {DateTime.Now}");
                return -1;
            }
        }
    }
}
