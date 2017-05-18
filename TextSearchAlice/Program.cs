using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSearchAlice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //string searchWithinThis = "ABCDEFGHIJKLMNOP";
            //string searchForThis = "DEF";
            //int firstCharacter = searchWithinThis.IndexOf(searchForThis);

            //Console.WriteLine("First occurrence: {0}", firstCharacter);
            //Console.ReadLine();

            string searchWithinThis = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            searchWithinThis = searchWithinThis.ToLower();

            Console.WriteLine("What word are you looking for? :");
            string searchForThis = Console.ReadLine();
            searchForThis = searchForThis.ToLower();

            int firstCharacter = searchWithinThis.IndexOf(searchForThis);

            if (firstCharacter >= 0)
                {
                Console.WriteLine(true);
                }
            else
                {
                Console.WriteLine(false);
                }

            Console.ReadLine();
            
        }
    }
}
