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
            int num = 10;
            while (num > 0)
            {
                Console.WriteLine(num);
                Console.ReadLine();
                num--;
            }

            //telling the user to guess a color from 4 options.
            Console.WriteLine("Guess the correct color. Options are blue, red, yellow, and green.");
            string color = Console.ReadLine();

            //the correct answer is red. isGeussed is true when red is entered
            bool isGuessed = color == "red";

            //do statement. The following are instructions for the program to follow until isGuessed is true
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

                        //the correct answer is here. It causes isGuessed to = true which stops the do loop from continuing.
                    case "red":
                        Console.WriteLine("You guessed red. That is correct!");
                        isGuessed = true;
                        break;

                        //the default cathes any other entries or mispellings.
                    default:
                        Console.WriteLine("Incorrect. That is not one of the options to choose from.");
                        Console.WriteLine("Guess a color. Options are blue, red, yellow, and green.");
                        color = Console.ReadLine();
                        break;
                }

            }
            //the while statement. The above chunk of code repeats until red is guessed.
            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
