using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Web.ViewModels.Exam
{
    public class ExamCreateViewModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Exam Name")]
        [StringLength(100, MinimumLength = 3)]
        public string ExamName { get; set; } = string.Empty;
        [Required]
        [DisplayName("Exam Date")]
        public DateTime ExamDate { get; set; } = DateTime.Now;
        [Required]
        [DisplayName("Maximum Marks")]
        public int MaximumMarks { get; set; }
        [Required]
        [DisplayName("Subject")]
        public int SubjectId { get; set; }
        public SelectList Subjects { get; set; }
        [Required]
        [DisplayName("Classes")]
        public List<int> SelectedClassIds { get; set; } = new List<int>();
        public List<SelectListItem> ClassCheckboxes { get; set; } = new List<SelectListItem>();
    }
}
