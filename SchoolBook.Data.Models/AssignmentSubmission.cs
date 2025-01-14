using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Data.Models
{
    public class AssignmentSubmission
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(600)]
        public string SubmissionContent { get; set; } = string.Empty;
        [Required]
        public DateTime SubmissionDate { get; set; } = DateTime.Now;
        public int? MarksObtained { get; set; }
        [MaxLength(300)]
        public string? Feedback { get; set; }
        [Required]
        public int AssignmentId { get; set; }
        [ForeignKey(nameof(AssignmentId))]
        public Assignment Assignment { get; set; } = null!;
        [Required]
        public string StudentId { get; set; } = string.Empty;
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set;} = null!;
    }
}
