using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookArrayPrep32
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish)");
            do
            {
                Console.Write("Name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    Console.Write("ID #: ");
                    string input = Console.ReadLine();
                    int id = int.Parse(input);
                    students.Add(id, newStudent);
                }
            }
            while (newStudent != "");

            Console.WriteLine("\nClass Roster");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Value + "(" + student.Key + ")");
            }
            Console.ReadLine();


        }
    }
}
