using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {   //basic math operation practice in C#
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine(combined);
            Console.ReadLine();

            int difference = 10 - 5;
            Console.WriteLine("Ten minus Five = " + difference.ToString());
            Console.ReadLine();

            int product = 10 * 5;
            Console.WriteLine(product);
            Console.ReadLine();

            double quotient = 100.0 / 17.0;
            Console.WriteLine(quotient);
            Console.ReadLine();

            int remainder = 11 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            bool trueOrFalse = 12 < 5;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            //real world application for bool usage
            int roomTemperature = 70;
            int currentTemperature = 70;

            bool isWarm = currentTemperature >= roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();

            //interactive console versions of math operations
            Console.WriteLine("Give me a number to multiply by 50.");
            string stringNum = Console.ReadLine();
            int num1 = Convert.ToInt32(stringNum);
            Console.WriteLine(stringNum + " multiplied by 50 = " + num1 * 50);
            Console.ReadLine();

            Console.WriteLine("Give me a number to add 25 to.");
            string stringNum1 = Console.ReadLine();
            int num2 = Convert.ToInt32(stringNum1);
            int plus25 = num2 + 25;
            Console.WriteLine(stringNum1 + " plus 25 = " + plus25);
            Console.ReadLine();

            Console.WriteLine("Give me a number to divide by 12.5");
            string stringNum2 = Console.ReadLine();
            double num3 = Convert.ToDouble(stringNum2);
            double divideBy = num3 / 12.5;
            Console.WriteLine(stringNum2 + " divided by 12.5 = " + divideBy);
            Console.ReadLine();

            Console.WriteLine("Give me a number compare to 50.");
            string stringNum3 = Console.ReadLine();
            int num4 = Convert.ToInt32(stringNum3);
            bool greaterThan50 = num4 > 50;
            string answer = Convert.ToString(greaterThan50);
            Console.WriteLine(stringNum3 + " is greater than 50. " + answer);
            Console.ReadLine();

            Console.WriteLine("Give me a number to add divide by 7 and then print the remainder.");
            string stringNum4 = Console.ReadLine();
            int num5 = Convert.ToInt32(stringNum4);
            int remainder1 = num5 % 7;
            Console.WriteLine(stringNum4 + " divided by 7 has a remainder of " + remainder1);
            Console.ReadLine();


        }
    }
}
