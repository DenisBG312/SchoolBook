using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolBook.Data.Models;
using SchoolBook.Web.Data;
using SchoolBook.Web.ViewModels.Assignment;
using System.Security.Claims;

namespace SchoolBook.Web.Controllers
{
    public class AssignmentController : Controller
    {
        private ApplicationDbContext _context;

        public AssignmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var assignments = await _context.Assignments
                .Include(a => a.Subject)
                .Include(a => a.Submissions)
                .ToListAsync();

            return View(assignments);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var viewModel = new CreateAssignmentViewModel
            {
                AssignedDate = DateTime.Now,
                Deadline = DateTime.Now.AddDays(7),
                AvailableSubjects = await _context.Subjects
                    .Select(s => new SelectListItem
                    {
                        Value = s.Id.ToString(),
                        Text = s.SubjectName
                    })
                    .ToListAsync(),
                ClassCheckboxes = await _context.Classes
                .Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.ClassName
                }).ToListAsync()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateAssignmentViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var assignment = new Assignment
                    {
                        Title = viewModel.Title,
                        Description = viewModel.Description,
                        AssignedDate = viewModel.AssignedDate,
                        Deadline = viewModel.Deadline,
                        SubjectId = viewModel.SubjectId
                    };

                    await _context.Assignments.AddAsync(assignment);
                    await _context.SaveChangesAsync();

                    foreach (var classId in viewModel.SelectedClassIds)
                    {
                        var assignmentClass = new AssignmentClass
                        {
                            AssignmentId = assignment.Id,
                            ClassId = classId
                        };
                        await _context.AssignmentClasses.AddAsync(assignmentClass);
                    }

                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Unable to create assignment. " + ex.Message);
                }
            }

            viewModel.AvailableSubjects = await _context.Subjects
                .Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.SubjectName
                })
                .ToListAsync();

            viewModel.ClassCheckboxes = await _context.Classes
                .Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.ClassName
                }).ToListAsync();

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetByClass()
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

            var assignments = await _context.Assignments
                .Include(a => a.Subject)
                .Include(a => a.Submissions)
                .Include(a => a.AssignmentClasses)
                .Where(a => a.AssignmentClasses.Any(ac => ac.ClassId == classId))
                .ToListAsync();

            return View(assignments);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var assignment = await _context.Assignments
                .Include(a => a.Subject)
                .Include(a => a.Submissions)
                .ThenInclude(s => s.Student)
                .ThenInclude(s => s.User)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (assignment == null)
            {
                return NotFound();
            }

            return View(assignment);
        }

        [HttpGet]
        public async Task<IActionResult> GetSubmissions(int id)
        {
            var submissions = await _context.AssignmentsSubmissions
                .Include(s => s.Student)
                .ThenInclude(s => s.User)
                .Where(s => s.AssignmentId == id)
                .OrderByDescending(s => s.SubmissionDate)
                .ToListAsync();

            return View(submissions);
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
