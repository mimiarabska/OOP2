using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsProject
{
    public class Student
    {
        public string Name { get; set; }
        public string FacultyNumber { get; set; }
        public Dictionary<Subject, int> Subjects { get; set; }

        public Student(string name, string facultyNumber, Dictionary<Subject, int> subjects)
        {
            Name = name;
            FacultyNumber = facultyNumber;
            Subjects = subjects;
        }

        public int GetSubjectsCount() => Subjects.Count;

        public List<string> GetStudentSubjects() => Subjects.Keys.Select(x => x.Name).ToList();

        public int GetGrade(string subjectName) => Subjects.FirstOrDefault(x => x.Key.Name == subjectName)!.Value;

        public double GetAverageGrade() => (double)Subjects.Values.ToList().Sum() / Subjects.Count;

        public void GetStudentInfo() =>
            Console.WriteLine("Student name: {0}, Student FacultyNumber: {1}", Name, FacultyNumber);

    }
}
