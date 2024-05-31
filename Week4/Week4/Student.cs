using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Student
    {
        public string Name { get; set; }
        public int FacultyNum { get; set; }

        public Dictionary<Subject, int> Subjects = new Dictionary<Subject, int>();

        public Student(string name , int facultyNum)
        {
            Name = name;
            FacultyNum = facultyNum;
        }

        public void AddGrade(Subject subject, int grade)
        {
            Subjects[subject] = grade;
        }
        public void AddSubjects(List<Subject> subjects)
        {
            foreach (var subject in subjects)
            {
                Subjects[subject] = -1; 
            }
        }
        public int GetGrade(Subject subject)
        {
            int grade;
            if (Subjects.TryGetValue(subject, out grade))
            {
                return grade;
            }
            else
            {
                return -1;
            }
        }
        public int GetNumOfSubjects() => Subjects.Count;

        public List<Subject> GetSubjects()
        {
            return new List<Subject>(Subjects.Keys);
        }
        public double GetAverageGrade()
        {
            if (Subjects.Count == 0)
                return 0;

            double total = 0;
            foreach (var grade in Subjects.Values)
            {
                total += grade;
            }
            return total / Subjects.Count;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student: {Name}, Faculty Number: {FacultyNum}");
            Console.WriteLine("Subjects:");
            foreach (var subject in Subjects.Keys)
            {
                Console.WriteLine($"- {subject.Name}: {Subjects[subject]}");
            }
            Console.WriteLine($"Average Grade: {GetAverageGrade()}");
        }





    }
}
