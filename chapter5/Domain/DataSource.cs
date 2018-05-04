using System;
using System.Collections.Generic;

namespace chapter5.Domain
{
    public static class DataSource
    {
        //Collection to hold data for the application.
        public static List<Teacher> Teachers;
        public static List<Student> Students;
        public static List<Grade> Grades;
        public static List<string> Subjects;

        //Mock data.
        public static void CreateDate(){
            Subjects = new List<string>() { "Math", "English", "History", "Geography", "Science" };

            Teachers = new List<Teacher>()
            {
                new Teacher() { UserId = 1, UserName = "vallee", Password = "password99", FirstName = "Esther", LastName = "Valle", Class = "3C" },
                new Teacher() { UserId = 2, UserName = "waited", Password = "password99", FirstName = "David", LastName = "Waite", Class = "4B" },
                new Teacher() { UserId = 3, UserName = "newmanb", Password = "password99", FirstName = "Belinda", LastName = "Newman", Class = "2A" }
            };

            Students = new List<Student>()
            {
                new Student() { UserId = 1, UserName = "liuk", Password = "password", TeacherId = 1, FirstName = "Kevin", LastName = "Liu" },
                new Student() { UserId = 2, UserName = "weberm", Password = "password", TeacherId = 1, FirstName = "Martin", LastName = "Weber" },
                new Student() { UserId = 3, UserName = "ligeorge", Password = "password", TeacherId = 1, FirstName = "George", LastName = "Li" },
                new Student() { UserId = 4, UserName = "millerl", Password = "password", TeacherId = 1, FirstName = "Lisa", LastName = "Miller" },
                new Student() { UserId = 5, UserName = "liur", Password = "password", TeacherId = 1, FirstName = "Run", LastName = "Liu" },
                new Student() { UserId = 6, UserName = "stewarts", Password = "password", TeacherId = 2, FirstName = "Sean", LastName = "Stewart" },
                new Student() { UserId = 7, UserName = "turnero", Password = "password", TeacherId = 2, FirstName = "Olinda", LastName = "Turner" },
                new Student() { UserId = 8, UserName = "ortonj", Password = "password", TeacherId = 2, FirstName = "Jon", LastName = "Orton" },
                new Student() { UserId = 9, UserName = "nixont", Password = "password", TeacherId = 2, FirstName = "Toby", LastName = "Nixon" },
                new Student() { UserId = 10, UserName = "guinotd", Password = "password", TeacherId = 2, FirstName = "Daniela", LastName = "Guinot" },
                new Student() { UserId = 11, UserName = "sundaramv", Password = "password", TeacherId = 3, FirstName = "Vijay", LastName = "Sundaram" },
                new Student() { UserId = 12, UserName = "grubere", Password = "password", TeacherId = 3, FirstName = "Eric", LastName = "Gruber" },
                new Student() { UserId = 13, UserName = "meyerc", Password = "password", TeacherId = 3, FirstName = "Chris", LastName = "Meyer" },
                new Student() { UserId = 14, UserName = "liyuhong", Password = "password", TeacherId = 3, FirstName = "Yuhong", LastName = "Li" },
                new Student() { UserId = 15, UserName = "liyan", Password = "password", TeacherId = 3, FirstName = "Yan", LastName = "Li" }
            };

            Grades = new List<Grade>()
            {
                new Grade() { StudentId = 1, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 1, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 1, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 1, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 2, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 2, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 2, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 2, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 3, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 3, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 3, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 3, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 4, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 4, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 4, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 4, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 5, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 5, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 5, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 5, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 6, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 6, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 6, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 6, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 7, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 7, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 7, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 7, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 8, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 8, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 8, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 8, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 9, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 9, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 9, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 9, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 10, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 10, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 10, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 10, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 11, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 11, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 11, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 11, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 12, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 12, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 12, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 12, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 13, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 13, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 13, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 13, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 14, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 14, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 14, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 14, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentId = 15, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentId = 15, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentId = 15, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentId = 15, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
            };
        }
    }
}
