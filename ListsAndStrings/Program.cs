using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> myList = new List<string> { "mike", "james", "steve", "tom", "timmy" };
            

            foreach (string myInt in myList)
            {
                if (myInt.Length == 5)
                {
                    Console.WriteLine(myInt);
                }
            }
            Console.ReadLine();
        }
    }
}
