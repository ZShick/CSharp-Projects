using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step279
{
    public class Operation
    {
        //adds 5 to the whatever the number is and returns it
        public int Add(int num)
        {
            return num + 5;
        }
        //adds 2 to whatever the decimal is and returns it
        public int Add1(decimal num1)
        {
            int sum = Convert.ToInt32(num1 + 2);
            return sum;
        }
        //converts the string into an integer, then adds 3 to it before returning it
        public int Add(string num2)
        {
            int num3 = Convert.ToInt32(num2);
            return num3 + 3;
        }
    }
}
