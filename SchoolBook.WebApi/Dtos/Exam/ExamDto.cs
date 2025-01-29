using SchoolBook.WebApi.Dtos.ExamClass;
using SchoolBook.WebApi.Dtos.Grade;

namespace SchoolBook.WebApi.Dtos.Exam
{
    public class ExamDto
    {
        public int Id { get; set; }
        public string ExamName { get; set; }
        public string ExamDate { get; set; }
        public int MaximumMarks { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public ICollection<ExamClassDto> ExamClasses { get; set; } = new List<ExamClassDto>();
        public ICollection<GradeDto> Grades { get; set; } = new List<GradeDto>();
    }
}
