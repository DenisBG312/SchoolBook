using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Web.ViewModels.Grade
{
    public class GradeDetailsViewModel
    {
        public string EvaluationName { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public DateTime GradedDate { get; set; }
        public string TeacherName { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string SubjectName { get; set; } = string.Empty;
        public string TeacherImgUrl { get; set; } = string.Empty;
        public string StudentImgUrl { get; set; } = string.Empty;

    }
}
