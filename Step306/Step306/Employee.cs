using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step306
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("This employee's name is: " + FirstName + " " + LastName);
            Console.ReadLine();
            //this method is inherited and overridden from the abstract superclass "Person".
        }
        public void Quit()
        {
            //defining the Quit() method is necessary beacuse the IQuittable interface is inherited
            Console.WriteLine("You have quit.");
            Console.ReadLine();
            return;
        }

    }
}
