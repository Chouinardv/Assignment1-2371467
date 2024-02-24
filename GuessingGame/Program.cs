using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            int computerGuess = randomizer.Next(1, 11);
            int userGuess;

            do
            {
                Console.Write("Guess the number: ");

                while (!int.TryParse(Console.ReadLine(), out userGuess) || userGuess < 1 || userGuess > 10)
                {
                    Console.Clear();

                    Console.WriteLine("Invalid input, enter a number between 1 and 10.");
                    Console.WriteLine("Guess the number: ");
                }

                if(userGuess != computerGuess)
                {
                    Console.WriteLine("Wrong guess.");
                }

            } while(userGuess != computerGuess);

            Console.WriteLine("Number guessed correctly!");

            Console.ReadKey();  

        }
    }
}
