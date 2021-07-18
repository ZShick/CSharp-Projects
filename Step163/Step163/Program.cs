using System;

namespace Step163
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for name and saves it
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            //asks for the name of the course and saves it
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            //asks for the page number, converts the string to integer, and then saves it
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

            //asks if they need help by requesting a true or false response which is then converted to bool and saved
            Console.WriteLine("Do you need help with anything else? Please answer \"true\" or \"false.\"");
            string helpNeeded = Console.ReadLine();
            bool helpNeed = Convert.ToBoolean(helpNeeded);

            //asks for positive experiences and then saves it
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();

            //asks for other feedback and then saves it
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();

            //asks how many hours they studied, converts the string to integer, and then saves it
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hrsStud = Convert.ToInt32(hoursStudied);

            //writes the final message and leaves it up on the screen till they exit the program so that they know they are done\
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
