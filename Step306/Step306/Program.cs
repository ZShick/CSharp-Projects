using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step306
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of Employee is made and then the altered SayName method is used to print the name out
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();

            //creating an object of type IQuittable and calling the Quit() method on it
            IQuittable x = new Employee();
            x.Quit();

        }

    }
}
