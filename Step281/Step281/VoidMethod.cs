using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step281
{
    public class VoidMethod
    {
        //created a class that has a void method that takes two integers as parameters
        public void vMethod(int num1, int num2)
        {
            //math operation is done on the first int while the second int is displayed on screen
            int sum = num1 + 4;
            Console.WriteLine(num2);
            Console.ReadLine();
            return;
        }
    }
}
