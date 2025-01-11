using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolBook.Web.Data;
using SchoolBook.Web.ViewModels.Grade;

namespace SchoolBook.Web.Controllers
{
    public class GradeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GradeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var currentUserId = GetUserId();

            var student = await _context.Students
                .FirstOrDefaultAsync(s => s.UserId == currentUserId);

            if (student == null)
            {
                return NotFound("You are not registered as a student.");
            }

            var gradesForCurrentStudent = await _context.Grades
                .Include(e => e.Exam)
                .Where(g => g.StudentId == student.Id)
                .Select(g => new GradeIndexViewModel()
                {
                    Id = g.Id,
                    ExamName = g.Exam.ExamName,
                    EvaluationName = g.EvaluationName,
                    GradedDate = g.GradedDate
                })
                .ToListAsync();

            return View(gradesForCurrentStudent);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var currentUserId = GetUserId();
            var student = await _context.Students
                .Include(s => s.User)
                .FirstOrDefaultAsync(s => s.UserId == currentUserId);

            if (student == null)
            {
                return NotFound("You are not registered as a student.");
            }

            var grade = await _context.Grades
                .Include(g => g.Exam)
                .ThenInclude(e => e.Subject)
                .ThenInclude(s => s.Class)
                .ThenInclude(c => c.Teacher)
                .ThenInclude(t => t.User)
                .FirstOrDefaultAsync(g => g.Id == id && g.StudentId == student.Id);

            if (grade == null)
            {
                return NotFound();
            }

            var gradeDetails = new GradeDetailsViewModel
            {
                EvaluationName = grade.EvaluationName,
                Comment = grade.Comment,
                GradedDate = grade.GradedDate,
                TeacherName = $"{grade.Exam.Subject.Class.Teacher.User.FirstName} {grade.Exam.Subject.Class.Teacher.User.LastName}",
                StudentName = $"{student.User.FirstName} {student.User.LastName}",
                ClassName = grade.Exam.Subject.Class.ClassName,
                SubjectName = grade.Exam.Subject.SubjectName
            };

            return View(gradeDetails);
        }


        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier)!;
        }
    }
}
