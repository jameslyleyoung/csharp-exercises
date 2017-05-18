using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsPrep32
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int> { 1, 2, 4, 4, 5, 6, 7, 8 };
            int sum = 0;

            foreach (int myInt in myList)
            {                
                if (myInt % 2 == 0)
                {
                    sum = sum + myInt;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
