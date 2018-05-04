using System;
using chapter5.Domain;

namespace chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSource.CreateDate();

            foreach(var student in DataSource.Students){
                Console.WriteLine("{0} {1} {2}", student.UserId, student.FirstName, student.LastName);
            }

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("");

            foreach(var teacher in DataSource.Teachers){
                Console.WriteLine("{0} {1} {2} {3}", teacher.UserId, teacher.FirstName, teacher.LastName, teacher.Class);
            }

            Student newStudent = new Student(DataSource.Students.Count + 1,
                                          "AllanB", "password", "Allan", "Bengtsson");

            Teacher t = new Teacher(1, "vallee", "password99", "Esther", "Valle", "3C");

            t.EnrollInClass(newStudent);

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("{0} {1} {2} {3}", newStudent.UserId, newStudent.FirstName, newStudent.LastName, newStudent.TeacherId);

            t.RemoveFromClass(newStudent);
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("{0} {1} {2} {3}", newStudent.UserId, newStudent.FirstName, newStudent.LastName, newStudent.TeacherId);

        }
    }
}
