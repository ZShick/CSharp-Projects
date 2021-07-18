using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step222
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcomes user and gets the weight of the package
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nHow much does your package weigh?");
            float weight = Convert.ToSingle(Console.ReadLine());

            //checks to see if the wieght is more than 50 or not. If it is, the user is informed that it is too heavy to be shipped. If not, then it moves on and asks for the width.
            string isItTooHeavy = weight > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : "What is the width of your package?";
            Console.WriteLine(isItTooHeavy);
            float width = Convert.ToSingle(Console.ReadLine());

            //asks for the height
            Console.WriteLine("What is the height of your package?");
            float height = Convert.ToSingle(Console.ReadLine());

            //asks for the length
            Console.WriteLine("What is the length of your package?");
            float length = Convert.ToSingle(Console.ReadLine());

            //adds up the 3 dimensions given to see if the total is greater than 50. If it is, the user is informed that it is too big to be shipped. If not, then it lists the final price.
            string isItTooBig = (width + height + length) > 50 ? "Package too big to be shipped via Package Express." : "Your estimated total for shipping this package is:";
            Console.WriteLine(isItTooBig);

            //final price is determined by multiplying all dimensions together. Then the product of that is multiplied by the weight. Finally, that product is divided by 100. The quotient is the final quote.
            float total = ((width * height * length) * weight) / 100;
            Console.WriteLine("$" + total + "\nThank you!");
            Console.ReadLine();

        }
    }
}
