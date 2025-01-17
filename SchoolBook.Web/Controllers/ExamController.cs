using System.Security.Claims;
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

        public async Task<IActionResult> StudentExams()
        {
            var userId = GetUserId();

            var student = await _context.Students
                .Include(s => s.Class)
                .FirstOrDefaultAsync(s => s.UserId == userId);

            if (student == null)
            {
                return NotFound();
            }

            var classId = student.Class?.Id;

            if (classId == null)
            {
                return NotFound();
            }

            var exams = await _context.Exams
                .Include(e => e.Subject)
                .Include(e => e.ExamClasses)
                .ThenInclude(ec => ec.Class)
                .Where(e => e.ExamClasses.Any(ec => ec.ClassId == classId))
                .Select(e => new ExamIndexViewModel
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
            var model = new ExamCreateViewModel
            {
                Subjects = new SelectList(_context.Subjects, "Id", "SubjectName"),
                ClassCheckboxes = await _context.Classes
                    .Select(c => new SelectListItem
                    {
                        Value = c.Id.ToString(),
                        Text = c.ClassName
                    })
                    .ToListAsync()
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ExamCreateViewModel model)
        {
            ModelState.Remove("Subjects");
            ModelState.Remove("Classes");

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

                foreach (var classId in model.SelectedClassIds)
                {
                    var examClass = new ExamClass
                    {
                        ExamId = exam.Id,
                        ClassId = classId
                    };
                    await _context.ExamClasses.AddAsync(examClass);
                }
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            model.Subjects = new SelectList(_context.Subjects, "Id", "SubjectName");
            model.ClassCheckboxes = await _context.Classes
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.ClassName,
                    Selected = model.SelectedClassIds.Contains(c.Id)
                })
                .ToListAsync();

            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var userId = GetUserId();

            var student = await _context.Students
                .Include(s => s.Class)
                .ThenInclude(t => t.Teacher)
                .ThenInclude(teacher => teacher.User)
                .FirstOrDefaultAsync(s => s.UserId == userId);

            if (student == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams
                .Include(e => e.ExamClasses)
                .ThenInclude(ec => ec.Class)
                .Include(e => e.Subject)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (exam == null)
            {
                return NotFound();
            }

            var examDetails = new ExamDetailsViewModel
            {
                Id = exam.Id,
                AssignedClasses = exam.ExamClasses.Select(ec => ec.Class.ClassName).ToList(),
                TeacherName = $"{student.Class.Teacher.User.FirstName} {student.Class.Teacher.User.LastName}",
                TeacherImgUrl = student.Class.Teacher.User.ProfileImgUrl,
                ExamDate = exam.ExamDate,
                ExamName = exam.ExamName,
                SubjectName = exam.Subject.SubjectName,
                MaximumMarks = exam.MaximumMarks
            };

            return View(examDetails);
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier)!;
        }
    }
}
