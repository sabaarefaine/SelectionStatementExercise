using System;

namespace SelectionStatementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise 2

            //\n + for line breaks
            Console.WriteLine("What is your favorite subject? \n" +
                "A. Math \n" +
                "B. History \n" +
                "C. English \n" +
                "D. Other \n");

            string fave = Console.ReadLine();

            //ignore lettercasing input by user
            switch (fave.ToLower())
            {
                case "a":
                case "math":
                    Console.WriteLine($"Math uses lots of numbers!");
                    break;
                case "b":
                case "history":
                    Console.WriteLine($"History has lots of interesting stories.");
                    break;
                case "c":
                case "english":
                    Console.WriteLine($"English introduced me to lots of good books!");
                    break;
                default:
                    Console.WriteLine($"Tell me more about your favorite subject!");
                    break;
            }


            //exercise 1
            var random = new Random();

            //program calculates random number
            var ranNumber = random.Next(1, 1000);

            Console.WriteLine("Guess my random number:");

            int guess = 0;

            //to allow user to keep guessing, do while around if else
            do
            {
                //in the do loop
                guess = int.Parse(Console.ReadLine());

                if (guess < ranNumber)
                {
                    Console.WriteLine("Too low. Guess again:");
                }
                else if (guess > ranNumber)
                {
                    Console.WriteLine("Too high. Guess again:");
                }
                else
                {
                    Console.WriteLine("You guessed correctly:");
                }
            }
            while (guess != ranNumber);
        }
    }
}
