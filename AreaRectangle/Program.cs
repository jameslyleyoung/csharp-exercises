using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double width;
            string input;
            double area;

            Console.WriteLine("What is the height of your rectangle?");
            input = Console.ReadLine();
            height = double.Parse(input);

            Console.WriteLine("What is the width of your rectangle?");
            input = Console.ReadLine();
            width = double.Parse(input);

            area = height * width;
            Console.WriteLine("The area of your rectangle is: " + area);
            Console.ReadLine();

            
        }
    }
}
