namespace StudentsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subject1 = new Subject("Math");
            var subject2 = new Subject("Biology");
            var subject3 = new Subject("Physics");

            var student1 = new Student("Peter", "stu0912345627",
                new Dictionary<Subject, int>() { { subject1, 6 }, { subject2, 6 }, { subject3, 6 } });

            var student2 = new Student("Simon", "stu0912345626",
                new Dictionary<Subject, int>() { { subject1, 5 }, { subject2, 5 }, { subject3, 5 } });

            var student3 = new Student("Simon", "stu0912345626",
                new Dictionary<Subject, int>() { { subject1, 4 }, { subject2, 4 }, { subject3, 4 } });

            var count1 = student1.GetSubjectsCount();
            var count2 = student2.GetSubjectsCount();
            var count3 = student3.GetSubjectsCount();

            var student1Subjects = student1.GetStudentSubjects();
            var student2Subjects = student2.GetStudentSubjects();
            var student3Subjects = student3.GetStudentSubjects();

            var student1Grade = student1.GetGrade("Math");
            var student2Grade = student2.GetGrade("Math");
            var student3Grade = student3.GetGrade("Math");

            var student1AvgGrade = student1.GetAverageGrade();
            var student2AvgGrade = student2.GetAverageGrade();
            var student3AvgGrade = student3.GetAverageGrade();

            student1.GetStudentInfo();
            student2.GetStudentInfo();
            student3.GetStudentInfo();

            var specialty = new Specialty(
                "Specialty1",
                new List<Student>() { student1, student2 },
                2024,
                new List<Subject>() { subject1, subject3 },
                new List<Subject>() { subject2 });

            var subject4 = new Subject("Informatics");
            var subject5 = new Subject("Finance");

            specialty.AddStudent(student3.Name, student3.FacultyNumber, new Dictionary<Subject, int> { { subject1, 6 } }, new Dictionary<Subject, int> { { subject5, 5 } });

            specialty.PrintInfo();
            var specialtyStudents = specialty.GetStudentsBySubject(subject1);

            var averageScoreBySubject = specialty.GetAvgScore(subject1);
            var averageScore = specialty.GetAvgScore();

            var top1Student = specialty.GetTopStudents(1);
        }
    }
}
