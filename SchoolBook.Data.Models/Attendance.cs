using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Data.Models
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime AttendanceDate { get; set; }
        public bool IsPresent { get; set; }
        [Required]
        public string StudentId { get; set; } = string.Empty;
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }
        [Required]
        public int ClassId { get; set; }
        [ForeignKey(nameof(ClassId))]
        public Class Class { get; set; }
    }
}
