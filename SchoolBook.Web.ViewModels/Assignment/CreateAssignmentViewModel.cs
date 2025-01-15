using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Web.ViewModels.Assignment
{
    public class CreateAssignmentViewModel
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(250)]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "Assigned Date")]
		public DateTime AssignedDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime Deadline { get; set; }

        [Required]
        [Display(Name = "Subject")]
        public int SubjectId { get; set; }

        public IEnumerable<SelectListItem>? AvailableSubjects { get; set; }
    }
}
