using System;
using System.Linq;
using System.Text.RegularExpressions;
using chapter5.Helpers;

namespace chapter5.Domain
{
    public class Teacher: User
    {
        private const int MAX_CLASS_SIZE = 8;

        //Public properties.
        public string Class { get; set; }


        public Teacher()
        {
            UserId = 0;
            UserName = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Class = string.Empty;
        }

        public Teacher(int teacherId, string userName, 
                       string password, string firstName, 
                       string lastName, string className){

            UserId = teacherId;
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Class = className;
        }

        public void EnrollInClass(Student student){
            int numStudents = DataSource.Students.Where(s => s.UserId == UserId).Count();

            if(numStudents == MAX_CLASS_SIZE){
                throw new ClassFullException("Class full: Unable to enroll student", Class);
            }

            if(student.TeacherId == 0){
                student.TeacherId = UserId;
            }else{
                throw new ArgumentException("Student", "Student is already assigned to a class");
            }
        }

        public void RemoveFromClass(Student student){
            if(student.TeacherId == UserId){
                student.TeacherId = 0;
            }else{
                throw new ArgumentException("Student", "Student is not assigned to this class");
            }
        }

        public override bool SetPassword(string pwd)
        {
            Match numericMatch = Regex.Match(pwd, @".*[0-9]+.*[0-9]+.*");

            if (pwd.Length >= 8 && numericMatch.Success)
            {
                passWord = pwd;
                return true;
            }

            return false;
        }
    }
}
