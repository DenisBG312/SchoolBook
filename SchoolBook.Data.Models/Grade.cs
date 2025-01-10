using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Data.Models
{
	public class Grade
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string EvaluationName { get; set; } = string.Empty;
		public string Comment {  get; set; } = string.Empty ;
		public DateTime GradedDate { get; set; } = DateTime.Now;
		[Required]
		public string StudentId { get; set; } = string.Empty;
		[ForeignKey(nameof(StudentId))]
		public Student Student { get; set; }
	}
}
