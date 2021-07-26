using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step369
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a DateTime variable that is equal to whatever the current time is
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current time is {0}", currentTime);

            //asking user for a number
            Console.WriteLine("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            //creating another DateTime variable that is equal to currentTime + the number the user typed. It is then displayed in a string to the console.
            DateTime futureTime = currentTime.AddHours(x);
            Console.WriteLine("In {0} hours the time will be {1}.", x, futureTime);
            Console.ReadLine();
        }
    }
}
