using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step313
{
    public class Employee
    {
        //created an employee class where each instance has an int Id property
        public int Id { get; set; }

        //creating a method that overloads the == and != operator in order to compare employee instances with each other
        public static bool operator ==(Employee x, Employee y)
        {
            return x.Id == y.Id;
        }
        public static bool operator !=(Employee x, Employee y)
        {
            return x.Id != y.Id;
        }
    }
}
