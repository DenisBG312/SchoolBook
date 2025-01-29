using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolBook.Web.Data;
using SchoolBook.WebApi.Dtos.Exam;
using SchoolBook.WebApi.Dtos.ExamClass;
using SchoolBook.WebApi.Dtos.Grade;

namespace SchoolBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ExamController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetExams")]
        public async Task<IActionResult> GetAll()
        {
            var exams = await _context.Exams
                .Include(e => e.Subject)
                .Include(e => e.ExamClasses)
                .ThenInclude(ec => ec.Class)
                .Include(e => e.Grades)
                .ThenInclude(g => g.Student)
                .ThenInclude(student => student.User)
                .ToListAsync();

            var examDtos = exams.Select(e => new ExamDto
            {
                Id = e.Id,
                ExamName = e.ExamName,
                ExamDate = e.ExamDate.ToString("yyyy MMMM dd"),
                MaximumMarks = e.MaximumMarks,
                SubjectId = e.SubjectId,
                SubjectName = e.Subject?.SubjectName ?? "Unknown",

                ExamClasses = e.ExamClasses.Select(ec => new ExamClassDto
                {
                    ExamId = ec.ExamId,
                    ClassId = ec.ClassId,
                    ClassName = ec.Class?.ClassName ?? "Unknown"
                }).ToList(),

                Grades = e.Grades.Select(g => new GradeDto
                {
                    Id = g.Id,
                    EvaluationName = g.EvaluationName,
                    Comment = g.Comment,
                    GradedDate = g.GradedDate.ToString("yyyy-MM-ddTHH:mm:ss.fffffff"),
                    ExamId = g.ExamId,
                    ExamName = e.ExamName,
                    StudentId = g.StudentId,
                    StudentName = g.Student?.User.FirstName + " " + g.Student?.User.LastName ?? "Unknown"
                }).ToList()

            }).ToList();

            return Ok(examDtos);
        }
    }
}
