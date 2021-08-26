using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //created a string of names
            string[] family = { "Bob ", "Carlos ", "Clara ", "Tiffany " };

            //foreach loop. Asks user for their last name then add that name onto the existing list of names to see what the names would look like if they shared the user's last name.
            foreach (string name in family)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Above are a few random names. If they were your family members they would share your last name. Lets see what that'd look like! What is your last name?");
            string lastName = Console.ReadLine();
            family = family.Select(name => name + lastName).ToArray();

            foreach (string name in family)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Wow! That's cool!");
            Console.ReadLine();

            //infinite loop that I then fixed with a break statement.
            while (true)
            {
                Console.WriteLine("Help I'm trapped in an infinite loop!");
                break;
            }
            Console.WriteLine("NVM. The infinite loop has been fixed.");
            Console.ReadLine();

            //created list of scores. Then iterated through the list. Then iterated again but stopped partway through the list.
            Console.WriteLine("The list of scores are: ");

            List<int> scores = new List<int>() { 88, 74, 65, 49, 88, 95, 97, 98, 90, 57, 69, 71, 80 };
            for (int i = 0; i < scores.Count; i++)
            {
                Console.WriteLine(scores[i]);
            }
            Console.ReadLine();

            Console.WriteLine("The first 7 off that list are: ");

            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(scores[i]);
            }
            Console.ReadLine();
            
            //created a list of letters in the alphabet followed by a "-c" or a "-v" to represent it being a consonant or vowel.
            List<string> alphabet = new List<string>() { "A -v", "B -c", "C -c", "D -c", "E -v", "F -c", "G -c", "H -c", "I -v", "J -c", "K -c", "L -c", "M -c", "N -c", "O -v", "P -c", "Q -c", "R -c", "S -c", "T -c", "U -v", "V -c", "W -c", "X -c", "Y -cv", "Z -c" };
            Console.WriteLine("The Alphabet is full of vowels and consonant. To see a list of one or the other type in a lowercase \"v\" or \"c\":");
            string searchLetter = Console.ReadLine();

            //asks user to type in a "c" or "v" to get a list of vowels or consonants. Program searches and prints out all matching results that contain the selected character.
            if (searchLetter == "c" || searchLetter == "v")
            {
                foreach (string item in alphabet)
                {
                    if (item.Contains(searchLetter))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else
            {
                Console.WriteLine("You did not enter a lowercase \"v\" or \"c\".");
                Console.ReadLine();
                return;
            }

            //Same as above but only prints off the first match from the List rather than all of them.
            Console.WriteLine("Now let's look only at the first consonant or vowell. Again, type in a lowercase \"v\" or \"c\" to list the first of either type:");
            string searchLetter1 = Console.ReadLine();

            if (searchLetter1 == "c" || searchLetter1 == "v")
            {
                foreach (string item1 in alphabet)
                {
                    if (item1.Contains(searchLetter1))
                    {
                        Console.WriteLine(item1);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("You did not enter a lowercase \"v\" or \"c\".");
                Console.ReadLine();
                return;
            }

            //created list of shirts by color. All but "red" have multiple instances in the list representing the same color shirt stored in different places in a warehouse.
            List<string> shirts = new List<string>() { "blue", "red", "purple", "green", "green", "purple", "green", "blue" };
            Console.WriteLine("There are shirts in varying colors stored in a warehouse. There may be multiples of the same color. Type in one of the following colors to locate an index where you can find it at: green, purple, red, or blue.");
            string searchColor = Console.ReadLine();

            //if the user enters in a search term correctly the program continues and iterates through each item in the list, printing out matches to the console by their index number.
            if (searchColor == "blue" || searchColor == "red" || searchColor == "purple" || searchColor == "green")
            {
                for (int j = 0; j < shirts.Count; j++)
                {
                    if (shirts[j] == searchColor)
                    {
                        Console.WriteLine(j);
                    }
                }
            }
            else
            {
                Console.WriteLine("You did not enter a correct input.");
                Console.ReadLine();
                return;
            }

            //Created hash sets to store some additional information. 
            HashSet<string> distinct = new HashSet<string>();
            HashSet<string> duplicates = new HashSet<string>();

            //foreach loop sorts through each item in the list and adds each disticnt string to one hash set and each item that has duplicates to another hash set.
            foreach (string shirt in shirts)
                if (!distinct.Add(shirt))
                    duplicates.Add(shirt);

            //Then the console writes out a list of colors that appear more than once.
            Console.WriteLine("These are the the colors that appear on the list more than once:");
            duplicates.ToList<String>()
                .ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }
    }
}
