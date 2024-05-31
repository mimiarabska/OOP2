using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsProject
{
    public class Specialty
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public int CourseYear { get; set; }
        public List<Subject> CommonSubjects { get; set; }
        public List<Subject> Electives { get; set; }

        public Specialty(
            string name,
            List<Student> students,
            int courseYear,
            List<Subject> commonSubjects,
            List<Subject> electives)
        {
            Name = name;
            Students = students;
            CourseYear = courseYear;
            CommonSubjects = commonSubjects;
            Electives = electives;
        }

        public void AddStudent(string name, string facultyNumber, Dictionary<Subject, int> electives, Dictionary<Subject, int> commonSubjects) =>
            Students.Add(new Student(name, facultyNumber, commonSubjects.Union(electives).ToDictionary(x => x.Key, x => x.Value)));

        public void PrintInfo()
        {
            Console.WriteLine("Specialty Name: " + Name);
            Console.WriteLine("Students Count: " + Students.Count);

            Console.WriteLine("Common Subjects: ");
            foreach (var commonSubject in CommonSubjects)
                Console.WriteLine("Subject Name: " + commonSubject.Name);

            Console.WriteLine("Electives: ");
            foreach (var elective in Electives)
                Console.WriteLine("Subject Name: " + elective.Name);
        }

        public List<Student> GetStudentsBySubject(Subject subject) =>
            Students.Where(x => x.Subjects.Keys.Contains(subject)).ToList();

        public double GetAvgScore(Subject subject)
        {
            var subjectGrades = Students
                .Select(x => x.Subjects.FirstOrDefault(x => x.Key.Name == subject.Name))
                .Select(x => x.Value)
                .ToList();

            return Math.Round((double)subjectGrades.Sum() / subjectGrades.Count(), 2);
        }

        public double GetAvgScore()
        {
            var avgGrades = new List<double>();

            foreach (var student in Students)
                avgGrades.Add(student.GetAverageGrade());

            return Math.Round(avgGrades.Sum() / avgGrades.Count, 2);
        }

        public List<StudentAvgScore> GetTopStudents(int n)
        {
            var result = new List<StudentAvgScore>();

            foreach (var student in Students)
            {
                result.Add(new StudentAvgScore
                {
                    Student = student,
                    AvgScore = Math.Round(student.GetAverageGrade(), 2)
                });
            }

            return result.OrderByDescending(x => x.AvgScore).Take(n).ToList();
        }
    }

    public struct StudentAvgScore
    {
        public Student Student;
        public double AvgScore;
    }
}
