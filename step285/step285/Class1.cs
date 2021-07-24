using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step285
{
    public class Class1
    {
        //void method created that takes an integer and divides it by two then displays the quotient
        public void vMethod(int num1)
        {
            int quotient = num1 / 2;
            Console.WriteLine(quotient);
            Console.ReadLine();
            return;
        }
        public void outputParams(out int num8, out int num9)
            //a method with output parameters. When called it'll give out "4" and then "3".
        {
            num8 = 4;
            num9 = 3;
        }
        public static void OverLoad(int y)
            //1 of 2 static functions that both add 7 to a number and then display the sum.
        {
            int sum = y + 7;
            Console.WriteLine("7 added to you number equals: " + sum);
            Console.ReadLine();
            return;
        }
        //2 of 2
        public static void OverLoad(int w, int q = 0)
        {
            int sum = w + 1 + 2 + 3 + 1 + q;
            Console.WriteLine("7 added to you number equals: " + sum);
            Console.ReadLine();
            return;
        }
    }
}
