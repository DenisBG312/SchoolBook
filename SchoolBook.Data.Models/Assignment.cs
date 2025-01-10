using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Data.Models
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;
        [MaxLength(250)]
        public string? Description { get; set; }
        [Required]
        public DateTime AssignedDate { get; set; } = DateTime.Now;
        [Required]
        public DateTime Deadline { get; set; }
        [Required]
        public int SubjectId { get; set; }
        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; } = null!;

        public ICollection<AssignmentSubmission> Submissions { get; set; } = new HashSet<AssignmentSubmission>();
    }
}
