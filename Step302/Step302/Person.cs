using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302
{
    //class is abstract so that no instances of it can be made
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void SayName()
        {
            //made this method virtual so that the Employee class can alter it. It prints out a persons name.
            Console.WriteLine(FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
