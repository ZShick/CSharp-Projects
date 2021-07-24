using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step285
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for a number. Instantiates an object of Class1 and calls a method while passing "num" as a parameter
            Console.WriteLine("Enter a number to divide it by 2:");
            int num = Convert.ToInt32(Console.ReadLine());
            var classObject = new Class1();
            classObject.vMethod(num);

            int num4, num5;//declaring variables to use later

            //calling a method that will output values for us for num4 and num5 adn then typing them out
            classObject.outputParams(out num4, out num5);
            Console.WriteLine("The Output parameters method determined that num4 = " + num4 + " and that num5 = " + num5 + ".");
            Console.ReadLine();

            //asks for a number and then calls the OverLoad method which is the name of two different methods that do the same thing.
            Console.WriteLine("Give me a number to add 7 to: ");
            int y = Convert.ToInt32(Console.ReadLine());
            //result is written in console
            Class1.OverLoad(y);
        }
    }
}
