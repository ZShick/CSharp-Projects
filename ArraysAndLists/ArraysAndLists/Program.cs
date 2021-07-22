using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        

        //creating a string array and then asking the user for an input. The input they give is converted into an integer.
        string[] stringArray = { "Cero", "Uno.", "Dos.", "Tres.", "Quatro" };
        Console.WriteLine("Please type in a 0, 1, 2, 3, or 4.");
        int arrayNum = Convert.ToInt32(Console.ReadLine());

        //if the integer they gave meets the criteria then the string at that index of the array is displayed. If not they are told it is an incorrect input and the program ends.
        if (arrayNum >= 0 && arrayNum <= 4)
        {
            Console.WriteLine("That number in spanish is " + stringArray[arrayNum]);
            Console.ReadLine();
            //creating an integer array and asking the user for an input. The input is then converted into an integer.
            int[] intArray = { 53, 123, 1, 87, 999999 };
            Console.WriteLine("Please type in a 0, 1, 2, 3, or 4.");
            int arrayNum1 = Convert.ToInt32(Console.ReadLine());

            //if the integer they gave meets the criteria then the number at that index of the array is displayed. If not they are told it is an incorrect input and the program ends.
            if (arrayNum >= 0 && arrayNum <= 4)
            {
                Console.WriteLine("The number at that location is " + intArray[arrayNum1]);
                Console.ReadLine();
                //Creating a list with 4 indexes maximum, and adding 4 colors to the list.
                List<string> stringList = List<string>(4);
                stringList.Add("Red.");
                stringList.Add("Yellow.");
                stringList.Add("Green.");
                stringList.Add("Purple.");

                //asks the users a funny question to prompt them to type in a number between 0 and 3.
                Console.WriteLine("We will now tell you what color your ghost will be when you die! To find out, type a 0, 1, 2, or 3.");
                int listNum = Convert.ToInt32(Console.ReadLine());

                //if the number is between 0 and 3 then they are given a response tailored to the number they picked.
                if (listNum >= 0 && listNum <= 3)
                {
                    Console.WriteLine("Your future Ghostly essence will be imbued with a " + stringList[listNum] + " color!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect input.");
                    Console.ReadLine();
                    return;
                }

            }
            else
            {
                Console.WriteLine("Incorrect input.");
                Console.ReadLine();
                return;
            }
        }
        else
        {
            Console.WriteLine("Incorrect input.");
            Console.ReadLine();
            return;
        }
    }
}

