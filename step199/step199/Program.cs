using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step199
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks age and converts it to integer
            Console.WriteLine("What is your age?");
            string stringAge = Console.ReadLine();
            int age = Convert.ToInt32(stringAge);

            //asks if they have ever had a DUI and converts it to a boolean variable
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false.\"");
            string stringDUI = Console.ReadLine();
            bool dui = Convert.ToBoolean(stringDUI);

            //asks how many speeding tickets they have had and converts it to an integer
            Console.WriteLine("How many Speeding tickets do you have?");
            string stringTickets = Console.ReadLine();
            int tickets = Convert.ToInt32(stringTickets);

            //creates 2 boolean variables
            bool over15 = age >= 15;
            bool lessThan3Tickets = tickets <= 3;

            //creates the final boolean variable that will be referenced when determining if someone is allowed to get car insurance
            bool qualified = over15 && !dui && lessThan3Tickets;

            //prints the answer
            Console.WriteLine("Qualified?\n" + qualified);
            Console.ReadLine();

        }
    }
}
