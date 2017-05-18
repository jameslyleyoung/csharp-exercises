using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPrep32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fib = new int[6] { 1, 1, 2, 3, 5, 8 };
            foreach (int i in fib)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
