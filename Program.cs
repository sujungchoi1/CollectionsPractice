using System;
using System.Collections.Generic;


namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            // Create an array to hold integer values 0 through 9
            int[] arrayOfInts = new int[] {0,1,2,3,4,5,6,7,8,9};
            foreach (int number in arrayOfInts)
            {
                Console.WriteLine(number);
            }
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] booArray = new bool[10];
            for (int idx = 0; idx < booArray.Length; idx++) {
                if (idx % 2 == 0)
                {
                    booArray[idx] = true;
                }
                if (idx % 2 != 0)
                {
                    booArray[idx] = false;
                }
            }
            foreach (bool boo in booArray)
            {
                Console.WriteLine(boo);
            }

            // List of Flavors
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> iceCream = new List<string>();
            iceCream.Add("butter pecan");
            iceCream.Add("moose tracks");
            iceCream.Add("pistachio");
            iceCream.Add("chocolate");
            iceCream.Add("vanilla");
            foreach (string flavor in iceCream) 
            {
                Console.WriteLine(flavor);
            }
            // Output the length of this list after building it
            Console.WriteLine(iceCream.Count);
            // Output the third flavor in the list, then remove this value
            Console.WriteLine(iceCream[2]);
            iceCream.RemoveAt(2);
            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(iceCream.Count);

            // User Info Dictionary
            // Create a dictionary that will store both string keys as well as string values
            // Add key/value pairs to this dictionary where:
            // each key is a name from your names array
            // each value is a randomly select a flavor from your flavors list.
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            
            Dictionary<string,string> info =  new Dictionary<string,string>();
            Random rand = new Random();

            for(int val = 0; val < 4; val++)
            {
                // info.Add(names[val], names[val]);
                info.Add(names[val], iceCream[rand.Next(0,4)]);
            }

            foreach (KeyValuePair<string,string> entry in info)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

        }
    }
}
