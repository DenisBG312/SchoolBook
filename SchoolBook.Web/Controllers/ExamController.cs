using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolBook.Data.Models;
using SchoolBook.Web.Data;
using SchoolBook.Web.ViewModels.Exam;

namespace SchoolBook.Web.Controllers
{
    public class ExamController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ExamController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var exams = await _context.Exams
                .Include(s => s.Subject)
                .Select(e => new ExamIndexViewModel()
                {
                    Id = e.Id,
                    ExamDate = e.ExamDate,
                    ExamName = e.ExamName,
                    SubjectName = e.Subject.SubjectName
                })
                .ToListAsync();

            return View(exams);
        }
    }
}
