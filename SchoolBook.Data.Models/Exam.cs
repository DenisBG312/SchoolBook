using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Data.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string ExamName { get; set; } = string.Empty;
        [Required]
        public DateTime ExamDate { get; set; }
        [Required]
        public int MaximumMarks { get; set; }
        [Required]
        public int SubjectId { get; set; }
        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; }

        public ICollection<Grade> Grades { get; set; } = new HashSet<Grade>();
    }
}
