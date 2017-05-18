using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gallons;
            double mpg;
            string input;

            Console.Write("How many miles have you driven?");
            input = Console.ReadLine();
            miles = double.Parse(input);
            
            Console.Write("How many gallons of gas used?");
            input = Console.ReadLine();
            gallons = double.Parse(input);

            mpg = miles / gallons;
            Console.WriteLine("Your Miles Per Gallon is: " + mpg);
            Console.ReadLine();
        }
    }
}
