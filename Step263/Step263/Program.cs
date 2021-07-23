using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step263
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created a list of integers and printed them out.
            Console.WriteLine("Here is a list of numbers:");
            List<int> nums = new List<int>() { 7, 8, 45, 6, 60, 66, 35, 32, 30, 1, 85 };
            nums.ForEach(i => Console.Write(i + "\n"));
            //Created a new list which will store and display the new information we get after dividing each integer by the number the user gives.
            List<int> numsAfterDivision = new List<int>(nums.Count);
            Console.WriteLine("\nPlease give me a number besides zero to divide each item in my list by.");

            try
                //try and catch block used to handle possible errors
            {
                //the number the user gave is converted from string to int.
                int divideBy = Convert.ToInt32(Console.ReadLine());
                //each int in the first list is divided by the user's number and the quotient is stored as a new item in the new list in the correct order.
                foreach (int num in nums)
                {
                    numsAfterDivision.Add(num / divideBy);
                }
                //This just adds space so the list of new numbers are seperated from the number the user picked.
                Console.WriteLine("");
                //each item in the new list is printed out on a new line.
                numsAfterDivision.ForEach(i => Console.Write(i + "\n"));
            }
            //catches exceptions when something other than numbers are entered
            catch (FormatException)
            {
                Console.WriteLine("Please enter only numbers.");
            }
            //catches exceptions when the user tries to divide by zero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
            }
            //catcehs anything else I may not have thought of
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally is the necessary end of a try catch block. This one just keeps the program open until the user has read what they need to.
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
