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

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            ViewBag.IsTeacher = await _context.Teachers.AnyAsync(t => t.UserId == userId);

            return View(submission);
        }

        [HttpGet]
        public async Task<IActionResult> Submit(int id)
        {
            var userId = GetUserId();

            var student = await _context.Students
                .Include(s => s.Class)
                .Include(s => s.User)
                .FirstOrDefaultAsync(s => s.UserId == userId);

            if (student == null)
            {
                return NotFound();
            }

            var assignment = await _context.Assignments
                .Include(a => a.Subject)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (assignment == null)
            {
                return NotFound();
            }

            var existingSubmission = await _context.AssignmentsSubmissions
                .FirstOrDefaultAsync(s => s.AssignmentId == id && s.StudentId == student.Id);

            if (existingSubmission != null)
            {
                return RedirectToAction("Details", "AssignmentSubmission", new { id = existingSubmission.Id });
            }

            var viewModel = new SubmitAssignmentViewModel
            {
                Id = id,
                StudentId = student.Id,
                StudentName = $"{student.User.FirstName} {student.User.LastName}",
                ClassName = student.Class.ClassName,
                AssignmentTitle = assignment.Title,
                SubmissionContent = string.Empty
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Submit(SubmitAssignmentViewModel viewModel)
        {
            var userId = GetUserId();

            var student = await _context.Students
                .Include(s => s.Class)
                .Include(s => s.User)
                .FirstOrDefaultAsync(s => s.UserId == userId);

            if (student == null)
            {
                return NotFound();
            }

            var assignment = await _context.Assignments
                .Include(a => a.Subject)
                .FirstOrDefaultAsync(a => a.Id == viewModel.Id);

            if (assignment == null)
            {
                return NotFound();
            }

            viewModel.StudentId = student.Id;
            viewModel.StudentName = $"{student.User.FirstName} {student.User.LastName}";
            viewModel.ClassName = student.Class.ClassName;
            viewModel.AssignmentTitle = assignment.Title;

            ModelState.Remove("StudentId");

            if (ModelState.IsValid)
            {
                var submission = new AssignmentSubmission
                {
                    AssignmentId = viewModel.Id,
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Rate(int assignmentSubmissionId, int marksObtained, string feedback)
        {
            var submission = await _context.AssignmentsSubmissions
                .FirstOrDefaultAsync(s => s.Id == assignmentSubmissionId);

            if (submission == null)
            {
                return NotFound();
            }

            submission.MarksObtained = marksObtained;
            submission.Feedback = feedback;

            _context.Update(submission);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { id = submission.Id });
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
