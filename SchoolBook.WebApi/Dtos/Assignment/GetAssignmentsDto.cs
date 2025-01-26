using SchoolBook.WebApi.Dtos.AssignmentClass;
using SchoolBook.WebApi.Dtos.Submission;

namespace SchoolBook.WebApi.Dtos.Assignment
{
    public class GetAssignmentsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime Deadline { get; set; }
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public List<AssignmentClassDto> AssignmentClasses { get; set; } = new();
        public List<SubmissionDto> Submissions { get; set; } = new();
    }
}
