using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [HttpGet]
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

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var viewModel = new ExamCreateViewModel
            {
                Subjects = new SelectList(await _context.Subjects.ToListAsync(), "Id", "SubjectName"),
                Classes = new SelectList(await _context.Classes.ToListAsync(), "Id", "ClassName")
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ExamCreateViewModel model)
        {
            ModelState.Remove("Subjects");
            ModelState.Remove("Class");

            if (ModelState.IsValid)
            {
                var exam = new Exam
                {
                    ExamName = model.ExamName,
                    ExamDate = model.ExamDate,
                    MaximumMarks = model.MaximumMarks,
                    SubjectId = model.SubjectId,

                };

                await _context.Exams.AddAsync(exam);
                await _context.SaveChangesAsync();

                var examClass = new ExamClass()
                {
                    ExamId = exam.Id,
                    ClassId = model.ClassId
                };

                await _context.ExamClasses.AddAsync(examClass);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            model.Subjects = new SelectList(_context.Subjects, "Id", "SubjectName");
            model.Classes = new SelectList(await _context.Classes.ToListAsync(), "Id", "ClassName");

            return View(model);
        }
    }
}
