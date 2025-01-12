using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Web.ViewModels.Exam
{
    public class ExamDetailsViewModel
    {
        public int Id { get; set; }
        public string ExamName { get; set; } = null!;
        public DateTime ExamDate { get; set; }
        public int MaximumMarks { get; set; }
        public string SubjectName { get; set; } = null!;
        public string TeacherName { get; set; } = null!;
        public string TeacherImgUrl { get; set; } = null!;
        public int StudentCount { get; set; }
        public double AverageGrade { get; set; }
        public List<string> AssignedClasses { get; set; } = new List<string>();
        public TimeSpan TimeUntilExam => ExamDate - DateTime.Now;
        public bool IsUpcoming => ExamDate > DateTime.Now;
    }
}
