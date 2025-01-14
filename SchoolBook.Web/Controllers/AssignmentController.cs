using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolBook.Data.Models;
using SchoolBook.Web.Data;
using SchoolBook.Web.ViewModels.Assignment;

namespace SchoolBook.Web.Controllers
{
    public class AssignmentController : Controller
    {
        private ApplicationDbContext _context;
        public AssignmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var assignments = await _context.Assignments
                .Include(a => a.Subject)
                .Include(a => a.Submissions)
                .ToListAsync();

            return View(assignments);
        }

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
                    .ToListAsync()
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

            return View(viewModel);
        }

        public async Task<IActionResult> GetByClass(int classId)
        {
            var assignments = await _context.Assignments
                .Include(a => a.Subject)
                .Include(a => a.Submissions)
                .Where(a => a.Subject.ClassId == classId)
                .ToListAsync();

            return View("Index", assignments);
        }

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitAssignment(AssignmentSubmission submission)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    submission.SubmissionDate = DateTime.Now;
                    await _context.AssignmentsSubmissions.AddAsync(submission);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Details), new { id = submission.AssignmentId });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Unable to submit assignment. " + ex.Message);
                }
            }

            return RedirectToAction(nameof(Details), new { id = submission.AssignmentId });
        }
    }
}
