namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Question[] questions = new Question[]
            {
            new Question("The Earth is flat.", new string[] {"True", "False"}, 1),
            new Question("Humans have 4 lungs.", new string[] {"True", "False"}, 1),
            new Question("Water boils at 100 degrees Celsius.", new string[] {"True", "False"}, 0),
            new Question("The moon is larger than the Earth.", new string[] {"True", "False"}, 1),
            new Question("Sound travels faster in water than in air.", new string[] {"True", "False"}, 0),
            new Question("Bats are blind.", new string[] {"True", "False"}, 1),
            new Question("Light travels faster than sound.", new string[] {"True", "False"}, 0),
            new Question("The capital of Australia is Sydney.", new string[] {"True", "False"}, 1),
            new Question("Gold is heavier than water.", new string[] {"True", "False"}, 0),
            new Question("Mount Everest is the tallest mountain on Earth.", new string[] {"True", "False"}, 0),

            new Question("What is the capital of Germany?", new string[] {"Paris", "Berlin", "Madrid", "New York"}, 1),
            new Question("What is 2+2?", new string[] {"5", "4", "2", "6"}, 1),
            new Question("The sun rises from?", new string[] {"East", "West", "North", "South"}, 0),
            new Question("Which planet is known as the Red Planet?", new string[] {"Earth", "Mars", "Jupiter", "Venus"}, 1),
            new Question("What is the largest ocean on Earth?", new string[] {"Atlantic Ocean", "Indian Ocean", "Arctic Ocean", "Pacific Ocean"}, 3),
            new Question("Who wrote 'Hamlet'?", new string[] {"Charles Dickens", "Mark Twain", "William Shakespeare", "Jane Austen"}, 2),
            new Question("Which element has the chemical symbol 'O'?", new string[] {"Oxygen", "Gold", "Osmium", "Oganesson"}, 0),
            new Question("What is the boiling point of water in Celsius?", new string[] {"100", "90", "80", "70"}, 0),
            new Question("How many continents are there?", new string[] {"5", "6", "7", "8"}, 2),
            new Question("Which is the smallest prime number?", new string[] {"1", "2", "3", "5"}, 1),
            new Question("Who painted the Mona Lisa?", new string[] {"Pablo Picasso", "Vincent van Gogh", "Leonardo da Vinci", "Michelangelo"}, 2),
            new Question("What is the capital of Japan?", new string[] {"Beijing", "Seoul", "Bangkok", "Tokyo"}, 3),
            new Question("Which gas is most abundant in the Earth's atmosphere?", new string[] {"Oxygen", "Carbon Dioxide", "Nitrogen", "Hydrogen"}, 2),
            new Question("How many colors are in a rainbow?", new string[] {"5", "6", "7", "8"}, 2),
            new Question("Who discovered penicillin?", new string[] {"Marie Curie", "Isaac Newton", "Alexander Fleming", "Albert Einstein"}, 2),
            new Question("Which country is the largest by land area?", new string[] {"USA", "Russia", "China", "Canada"}, 1),
            new Question("What is the chemical formula of water?", new string[] {"H2O", "CO2", "NaCl", "C6H12O6"}, 0),
            new Question("How many bones are in the human body?", new string[] {"206", "208", "210", "212"}, 0),
            new Question("Which is the longest river in the world?", new string[] {"Amazon", "Nile", "Yangtze", "Mississippi"}, 1),
            new Question("What is the largest mammal?", new string[] {"Elephant", "Blue Whale", "Giraffe", "Great White Shark"}, 1)
            
            };





            QuizHandler quizHandler = new QuizHandler(questions);
            quizHandler.ShowMenu();


            Console.ReadKey();
        }
    }
}
