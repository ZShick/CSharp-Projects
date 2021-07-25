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
        public abstract void SayName();
    }
}
