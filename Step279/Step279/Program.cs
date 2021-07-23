using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step279
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks user for a number then converts the number to an integer
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            var opObject = new Operation();

            //Add method is called and given the User's number as an integer for a parameter. The result of the method is displayed.
            var result = opObject.Add(num);
            Console.WriteLine(num + " plus 5 equals " + result);

            //asks user for a number then converts the number to an decimal
            Console.WriteLine("Enter a number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            //Add method is called and given the User's number as a decimal for a parameter. The result of the method is displayed.
            var result1 = opObject.Add(num1);
            Console.WriteLine(num1 + " plus 2 equals " + result1);

            //asks user for a number then converts the number to a a string
            Console.WriteLine("Enter a number: ");
            string num2 = Console.ReadLine();

            //Add method is called and given the User's number as a string for a parameter. The result of the method is displayed.
            var result2 = opObject.Add(num2);
            Console.WriteLine(num2 + " plus 3 equals " + result2);

            Console.ReadLine();
        }
    }
}
