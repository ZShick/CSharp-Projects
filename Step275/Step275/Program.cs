using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step275
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user for number
            Console.WriteLine("Enter a number and I will do three seperate operations with that number:");
            int num = Convert.ToInt32(Console.ReadLine());

            //creates an instance of the Operations class
            var opObject = new Operations();

            //calls the method that adds 5 then prints the sum
            var sum = opObject.Add5(num);
            Console.WriteLine(num + " plus 5 equals " + sum);

            //calls the method that subtracts 2 then prints the difference
            var difference = opObject.Minus2(num);
            Console.WriteLine(num + " minus 2 equals " + difference);

            //calls the method that multiplies by 9 then prints the product
            var product = opObject.Times9(num);
            Console.WriteLine(num + " times 9 equals " + product);

            Console.ReadLine();
        }
    }
}
