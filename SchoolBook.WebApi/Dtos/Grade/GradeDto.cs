namespace SchoolBook.WebApi.Dtos.Grade
{
    public class GradeDto
    {
        public int Id { get; set; }
        public string EvaluationName { get; set; }
        public string Comment { get; set; }
        public string GradedDate { get; set; }
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
    }
}
