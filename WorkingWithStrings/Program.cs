using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a\nnew line";
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";
            //string myString = String.Format("{1} = {0}", "First", "Second");
            //string myString = String.Format("{0:C}", 123.45);
            //string myString = String.Format("{0:N}", 1234567890);
            //string myString = string.Format("percentage = {0:P}", .123);
            string myString = string.Format("Phone number {0:(###) ###-####}", 1234567890);

            Console.WriteLine(myString);
            Console.ReadLine();

        }
    }
}
