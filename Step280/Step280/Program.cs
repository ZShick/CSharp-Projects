using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step280
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating variable that will store number if necessary
            int num1;
            int result;
            var opObject = new OptionalPs();
            //asking user to enter a number.
            Console.WriteLine("Choose a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //asking the user to make a choice in entering another number or not.
            Console.WriteLine("Either choose another number or hit enter. Your choice. ");
            //if they do then their second number is passed to the method along with the first
            if (int.TryParse(Console.ReadLine(), out num1))
                result = opObject.opParam(num, num1);     
            else
            //if second number not given the default is set to 0 and both are passed anyway
                result = opObject.opParam(num, num1 = 0);
            //Console then displays the equation that was done from calling the method
            Console.WriteLine(num + " + " + num1 + " = " + result);
            Console.ReadLine();
        }
    }
}
