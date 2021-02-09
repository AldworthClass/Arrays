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

            string[] names = {"Trinity", "Neo", "Morpheus", "Agent Smith", "Tank"};  
            Console.WriteLine(names[1] + " is 'The One'.");
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.WriteLine(names[0]); // This prints out the first element
            Console.WriteLine("There are " + names.Length + " names in my array.");
            names[3] = "Agent Smith";
            Console.WriteLine(names[3] + " is the bad guy.");
            names[names.Length - 1] = "Cypher";
            Console.WriteLine(names[names.Length - 1] + " is another bad guy.");

            Console.WriteLine();
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(i + ". " + names[i]);
            }

            Console.ReadLine(); // Keeps program from closing
        }
    }
}
