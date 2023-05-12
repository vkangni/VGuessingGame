using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guessing Game!");

            bool playAgain = true;
            while (playAgain)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 10);
                int numAttempts = 0;

                Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess what it is?");

                while (true)
                {
                    Console.Write("Enter your guess (or 'q' to quit): ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "q")
                    {
                        Console.WriteLine("Thanks for playing!");
                        playAgain = false;
                        break;
                    }

                    int guess;

                    if (int.TryParse(input, out guess))
                    {
                        numAttempts++;

                        if (guess == randomNumber)
                        {
                            Console.WriteLine("Congratulations! You guessed the number in " + numAttempts + " attempts!");
                            break;
                        }
                        else if (guess < randomNumber)
                        {
                            Console.WriteLine("Your guess is too low. Try again.");
                        }
                        else
                        {
                            Console.WriteLine("Your guess is too high. Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number or 'q' to quit.");
                    }
                }

                if (playAgain)
                {
                    Console.Write("Do you want to play again? (y/n): ");
                    string playAgainInput = Console.ReadLine();
                    if (playAgainInput.ToLower() != "y")
                    {
                        playAgain = false;
                    }
                }
            }
        }
    }
}
