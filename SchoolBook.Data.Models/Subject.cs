using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Data.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string SubjectName { get; set; } = string.Empty;
        [Required]
        public int ClassId { get; set; }
        [ForeignKey(nameof(ClassId))]
        public Class Class { get; set; } = null!;
        [Required]
        public string TeacherId { get; set; } = string.Empty;
        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; } = null!;

        public ICollection<Exam> Exams { get; set; } = new HashSet<Exam>();
        public ICollection<Assignment> Assignments { get; set; } = new HashSet<Assignment>();
    }
}
