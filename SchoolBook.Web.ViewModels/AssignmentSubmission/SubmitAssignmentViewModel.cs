using System.ComponentModel.DataAnnotations;

namespace SchoolBook.Web.ViewModels.AssignmentSubmission
{
    public class SubmitAssignmentViewModel
    {
        public int Id { get; set; }

        [Required]
        public string StudentId { get; set; } = string.Empty;

        [Required]
        [MaxLength(600)]
        public string SubmissionContent { get; set; } = string.Empty;

        public string AssignmentTitle { get; set; } = string.Empty;

        public string StudentName { get; set; } = string.Empty;

        public string ClassName { get; set; } = string.Empty;
    }
}
