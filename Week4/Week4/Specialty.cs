using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Specialty
    {
        public string Name { get; set; }
        public int CourseYear { get; set; }
        public List<Subject> CommonSubjects { get; set; }
        public List<Subject> Electives { get; set; }
        public List<Student> Students { get; set; }

        public Specialty(string name, int courseYear, List<Subject> commonSubjects, List<Subject> electives)
        {
            Name = name;
            CourseYear = courseYear;
            CommonSubjects = commonSubjects;
            Electives = electives;
            Students = new List<Student>();
        }

        public void AddStudent(string name, int facultyNumber, Dictionary<Student, List<Subject>> students)
        {
            Student student = new Student(name, facultyNumber);
            student.AddSubjects(CommonSubjects);
            Students.Add(student);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Specialty: {Name}, Year: {CourseYear}");
            Console.WriteLine("Common Subjects:");
            foreach (var subject in CommonSubjects)
            {
                Console.WriteLine($"- {subject.Name}");
            }
            Console.WriteLine("Elective Subjects:");
            foreach (var subject in Electives)
            {
                Console.WriteLine($"- {subject.Name}");
            }
            Console.WriteLine($"Number of Students: {Students.Count}");
        }
        public List<Student> GetStudentsBySubject(Subject subject) => Students.Where(student => student.GetSubjects().Contains(subject)).ToList();

            public double GetAvgScore()
        {
            double totalScore = 0;
            int count = 0;
            foreach (var student in Students)
            {
                totalScore += student.GetAverageGrade();
                count++;
            }
            if (count == 0)
            {
                return 0;
            }
            else
            {
                return totalScore / count;
            }
        }



    }
}
