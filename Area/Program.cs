using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Area
    {
        static void Main(string[] args)
        {
            int numNotUsed = 0
            double radius = 0;
            while (radius <= 0)
            {
                Console.WriteLine("What is the radius of your circle");
                string radiusString = Console.ReadLine();
                radius = double.Parse(radiusString);
                numNotUsed += 1;
            }
            double area = (radius * radius) * 3.14;

            Console.WriteLine("The area of your circle with a radius of " + radius + " is: " + area);
            Console.ReadLine();
        }   
    }
}
