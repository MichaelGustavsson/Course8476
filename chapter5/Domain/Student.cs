using System;
namespace chapter5.Domain
{
    public class Student: User, IComparable<Student>
    {
        public int TeacherId { get; set; }

        //Default constructor...
        public Student(){
            UserId = 0;
            UserName = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            TeacherId = 0;
        }

        //Overloaded constructor to setup the properties
        //of a new Student...
        public Student(int studentId,
                      string userName,
                      string password,
                      string firstName,
                      string lastName)
        {
            UserId = studentId;
            Password = passWord;
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddGrade(Grade grade){
            if (grade.StudentId == 0) { 
                grade.StudentId = UserId; 
            }
            else { 
                throw new ArgumentException("Grade", "Grade belongs to another student."); 
            }
        }

        public int CompareTo(Student other)
        {
            // Concatenate the LastName and FirstName of this student
            string thisStudentsFullName = LastName + FirstName;

            // Concatenate the LastName and FirstName of the "other" student
            string otherStudentsFullName = other.LastName + other.FirstName;

            // Use String.Compare to compare the concatenated names and return the result
            return (String.Compare(thisStudentsFullName, otherStudentsFullName));
        }

        public override bool SetPassword(string pwd)
        {
            if(pwd.Length >= 6){
                passWord = pwd;
                return true;
            }
            return false;
        }
    }
}
