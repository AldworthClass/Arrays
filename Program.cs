using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            string[] names = {"Trinity", "Neo", "Morpheus", "Agent Smith", "Tank"};  
            Console.WriteLine(names[1] + " is 'The One'.");
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.WriteLine(names[0]); // This prints out the first element
            Console.WriteLine("There are " + names.Length + " names in my array.");
            names[3] = "Agent Smith";
            Console.WriteLine(names[3] + " is the bad guy.");
            
            // Change the last name without hard coding an index number
            names[names.Length - 1] = "Cypher";
            Console.WriteLine(names[names.Length - 1] + " is another bad guy.");

            // Random Challenge
            Console.WriteLine();
            Console.WriteLine("Here is a random name:");
            Console.WriteLine(names[generator.Next()]);
            Console.WriteLine();

            // Prints all elements no matter what the size of the array is
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(i + ". " + names[i]);
            }

            Console.ReadLine(); // Keeps program from closing
        }
    }
}
