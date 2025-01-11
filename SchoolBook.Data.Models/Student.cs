using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolBook.Data.Models
{
    public class Student
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }
        [Required]
        public string ParentContact { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        public int ClassId { get; set; }
        [ForeignKey(nameof(ClassId))]
        public Class Class { get; set; }
        public ICollection<Grade> Grades { get; set; } = new HashSet<Grade>();
    }
}
