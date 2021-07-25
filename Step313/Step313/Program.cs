using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step313
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating two Employee objects and assigning them the same Ids
            Employee employee = new Employee();
            Employee employee1 = new Employee();
            employee.Id = 102;
            employee1.Id = 102;
            
            //calling the overloaded operator
            if (employee == employee1)
            {
                Console.WriteLine("These each reference the same employee.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("These each reference a different employee.");
                Console.ReadLine();
            }
        }
    }
}
