using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject math = new Subject("Matematika");
            Subject physics = new Subject("Fizika");

            Student student1 = new Student("Ani", 12345);
            student1.AddGrade(math, 5);
            student1.AddGrade(physics, 4);

            Console.WriteLine("Number of subjects for student1: " + student1.GetNumOfSubjects());
            Console.WriteLine("Subjects for student1:");
            foreach (var subject in student1.GetSubjects())
            {
                Console.WriteLine(subject.Name);
            }
            Console.WriteLine("Grade in Math for student1: " + student1.GetGrade(math));
            Console.WriteLine("Average Grade for student1: " + student1.GetAverageGrade());

            student1.PrintInfo();
        }
    }
}
