using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step281
{
    class Program
    {
        public static void Main(string[] args)
        {
            //instantiated the class and called the method passing in two numbers as parameters
            var voidObject = new VoidMethod();
            voidObject.vMethod(2, 4);
            //called it again but this time specified the parameters by name
            voidObject.vMethod(num1: 3, num2: 6);
        }
    }
}
