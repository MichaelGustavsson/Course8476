using System;
using System.Text.RegularExpressions;

namespace chapter5.Domain
{
    public class Grade
    {
        //Private member fields.
        private string _assessment;
        private string _assessmentDate;
        private string _subjectName;

        //Public properties.
        public string Comments { get; set; }
        public int StudentId { get; set; }


        public string Assessment
        {
            get { return _assessment; }
            set
            {
                Match matchGrade = Regex.Match(value,
                   @"[A-E][+-]?$");

                if (matchGrade.Success) { _assessment = value; }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        "Assessment",
                        "Assessment grade must be in the range A + to E - ");
                }
            }
        }

        public string AssessmentDate{
            get { return _assessmentDate; }
            set{
                DateTime assessmentDate;

                if (DateTime.TryParse(value, out assessmentDate))
                {
                    if (assessmentDate > DateTime.Now)
                    {
                        throw new ArgumentOutOfRangeException("AssessmentDate", "Assessment date must be on or before the current date");
                    }

                    _assessmentDate = assessmentDate.ToString("d");
                }
                else
                {
                    throw new ArgumentException("AssessmentDate", "Assessment date is not recognized");
                }
            }
        }

        public string SubjectName{
            get { return _subjectName; }
            set{
                if (DataSource.Subjects.Contains(value))
                {
                    _subjectName = value;
                }
                else
                {
                    throw new ArgumentException("Subject", "Subject is not recognized");
                }
            }
        }

        public Grade()
        {
            StudentId = 0;
            AssessmentDate = DateTime.Now.ToShortDateString();
            SubjectName = "Math";
            Assessment = "A";
            Comments = string.Empty;
        }

        public Grade(int studentId, string assessmentDate, string subject, string assessment, string comments){
            StudentId = studentId;
            Assessment = assessment;
            AssessmentDate = assessmentDate;
            Comments = comments;
            SubjectName = subject;
        }
    }
}
