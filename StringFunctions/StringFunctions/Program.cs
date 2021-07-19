using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //created 3 strings and then concatenated them together
            string abc = "A B C ";
            string def = "D E F ";
            string ghi = "G H I ";
            Console.WriteLine(abc + def + ghi);
            Console.ReadLine();

            //converting a string entirely to uppercase
            string lowerCase = "this string was originally all lowercase but is now uppercase thanks to the toupper method. sorry for yelling...";
            string upperCase = lowerCase.ToUpper();
            Console.WriteLine(upperCase);
            Console.ReadLine();

            //using stringbuilder to continually tweak, adjust, or add to an existing string.
            StringBuilder sb = new StringBuilder("Hello. ");

            Console.WriteLine(sb);
            Console.ReadLine();

            //adds another sentence
            sb.Append("My name is zach.");

            Console.WriteLine(sb);
            Console.ReadLine();

            //adds another sentence
            sb.Append(" This is a paragraph that is created using StringBuilder.");

            Console.WriteLine(sb);
            Console.ReadLine();

            //changes the lowercase z to a capital
            sb.Replace('z', 'Z');

            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
