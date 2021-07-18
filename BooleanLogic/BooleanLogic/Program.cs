using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND operators
            Console.WriteLine(true && true);//true
            Console.WriteLine(true && false);//false
            Console.WriteLine(false && false);//false

            //OR operators
            Console.WriteLine(true || true);//true
            Console.WriteLine(true || false);//true
            Console.WriteLine(false || false);//false

            //equal to operators
            Console.WriteLine(true == true);//true
            Console.WriteLine(true == false);//false
            Console.WriteLine(false == false);//true

            //not equal to operators
            Console.WriteLine(true != true);//false
            Console.WriteLine(true != false);//true
            Console.WriteLine(false != false);//false

            //XOR operators (one or the other but not both)
            Console.WriteLine(true ^ true);//false
            Console.WriteLine(true ^ false);//true
            Console.WriteLine(false ^ false);//false

            Console.ReadLine();
        }
    }
}
