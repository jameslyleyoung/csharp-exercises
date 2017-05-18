using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradebookPrep32
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students.Add(newStudent);
                }
            }
            while (newStudent != "");
            
            //Get Student grades
            foreach (string student in students)
            {
                Console.Write("Grade for " + student + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }

            //Print class roster
            Console.WriteLine("\nClass Roster:");
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < students.Count; i++)
            {
                myString.Append(students[i] + "(" + grades[i] + ")\n");
                
            }
            Console.WriteLine(myString);

            double sum = grades.Sum();
            double avg = sum / grades.Count;
            Console.WriteLine("Average grade: " + avg);
            Console.ReadLine();
        }
    }
}
