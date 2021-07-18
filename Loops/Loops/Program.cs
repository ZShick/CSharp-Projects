using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the correct color. Options are blue, red, yellow, and green.");
            string color = Console.ReadLine();

            bool isGuessed = color == "red";
            do
            {
                switch (color)
                {
                    case "blue":
                        Console.WriteLine("You guessed blue. Incorrect. Try again.");
                        Console.WriteLine("Guess a color. Options are blue, red, yellow, and green.");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("You guessed yellow. Incorrect. Try again.");
                        Console.WriteLine("Guess a color. Options are blue, red, yellow, and green.");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed green. Incorrect. Try again.");
                        Console.WriteLine("Guess a color. Options are blue, red, yellow, and green.");
                        color = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("You guessed red. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect. That is not one of the options to choose from.");
                        Console.WriteLine("Guess a color. Options are blue, red, yellow, and green.");
                        color = Console.ReadLine();
                        break;
                }

            }
            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
