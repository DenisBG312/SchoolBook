using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolBook.Data.Models;
using SchoolBook.Web.Data;
using SchoolBook.Web.ViewModels.AssignmentSubmission;
using System.Security.Claims;

namespace SchoolBook.Web.Controllers
{
    public class AssignmentSubmissionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AssignmentSubmissionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var submission = await _context.AssignmentsSubmissions
                .Include(s => s.Student)
                .ThenInclude(s => s.User)
                .Include(s => s.Assignment)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (submission == null)
            {
                return NotFound();
            }

            return View(submission);
        }

        [HttpGet("{assignmentId}")]
        public async Task<IActionResult> Submit(int assignmentId)
        {
            var userId = GetUserId();
            var student = await _context.Students
                .Include(u => u.User)
                .Include(s => s.Class)
                .FirstOrDefaultAsync(s => s.UserId == userId);

            if (student == null)
            {
                return NotFound();
            }

            var assignment = await _context.Assignments
                .Include(a => a.Subject)
                .FirstOrDefaultAsync(a => a.Id == assignmentId);

            if (assignment == null)
            {
                return NotFound();
            }

            var existingSubmission = await _context.AssignmentsSubmissions
                .FirstOrDefaultAsync(s => s.AssignmentId == assignmentId && s.StudentId == student.Id);

            if (existingSubmission != null)
            {
                return RedirectToAction("Details", "AssignmentSubmission", new { id = existingSubmission.Id });
            }

            var viewModel = new SubmitAssignmentViewModel()
            {
                Id = assignmentId,
                StudentId = student.Id,
                SubmissionContent = string.Empty,
                StudentName = student.User.FirstName + " " + student.User.LastName,
                ClassName = student.Class.ClassName,
                AssignmentTitle = assignment.Title,
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Submit(int assignmentId, SubmitAssignmentViewModel viewModel)
        {
            var userId = GetUserId();
            var student = await _context.Students
                .Include(s => s.Class)
                .FirstOrDefaultAsync(s => s.UserId == userId);

            if (student == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var submission = new AssignmentSubmission
                {
                    AssignmentId = assignmentId,
                    StudentId = student.Id,
                    SubmissionDate = DateTime.Now,
                    SubmissionContent = viewModel.SubmissionContent
                };

                _context.AssignmentsSubmissions.Add(submission);
                await _context.SaveChangesAsync();

                return RedirectToAction("Details", "AssignmentSubmission", new { id = submission.Id });
            }

            return View(viewModel);
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
