using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step292
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiates an employee object. Assign a first and last name to the instance.
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //am able to call the SayName method from the Person class because the Employee class inherits from it
            employee.SayName();
        }
    }
}
