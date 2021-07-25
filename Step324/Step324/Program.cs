using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step324
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks user to enter the name of the current day
            Console.WriteLine("Please enter the name of the current day: ");
            //creates an instance of a Day object named "today"
            Day today = new Day();
            //converts user input to a string variable
            string day1 = Console.ReadLine();
            try
            {
                //try catch block in case of error.
                //using the Enum.Parse method to convert the user input string variable into one of my enums IF it is true that it matches one of them
                today.DayName = (DayName)Enum.Parse(typeof(DayName), day1, true);
            }
            catch (Exception)
            {
                //If it does not match one of the listed options then this messages appears with instructions for them next time they run the program
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
                return;
            }
            //if it did match my enum list then that day name is printed out.
            Console.WriteLine("Today is " + today.DayName);
            Console.ReadLine();

        }
    }
}
