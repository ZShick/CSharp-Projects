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
            //this method is inherited but overridden from the abstract superclass "Person".
            Console.WriteLine("This employee's name is: ");
            //extra text is added to label this person as a n employee.
            base.SayName();

        }
    }
}
