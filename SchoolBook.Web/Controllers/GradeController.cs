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
                    ExamName = g.Exam.ExamName,
                    EvaluationName = g.EvaluationName,
                    GradedDate = g.GradedDate
                })
                .ToListAsync();

            return View(gradesForCurrentStudent);
        }


        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier)!;
        }
    }
}
