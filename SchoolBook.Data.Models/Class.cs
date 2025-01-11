using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Data.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(5)]
        public string ClassName { get; set; } = string.Empty;
        [Required]
        [MaxLength(10)]
        public string GradeLevel { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        public string Schedule { get; set; } = string.Empty;
        [Required]
        public string TeacherId { get; set; } = string.Empty;
        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; } = null!;
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();
        public ICollection<ExamClass> ExamClasses { get; set; } = new HashSet<ExamClass>();
    }
}
