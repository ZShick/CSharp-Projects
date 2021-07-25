using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("This employee's name is: " + FirstName + " " + LastName);
            Console.ReadLine();
            //this method is inherited and overridden from the abstract superclass "Person".
            Console.ReadLine();

        }
    }
}
