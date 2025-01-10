using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Data.Models
{
    public class Teacher
    {
        [Key] 
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
        [Required]
        public string Specialization { get; set; } = string.Empty;
        [Required]
        public DateTime HireDate { get; set; } = DateTime.Now;
        public ICollection<Class> Classes { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
