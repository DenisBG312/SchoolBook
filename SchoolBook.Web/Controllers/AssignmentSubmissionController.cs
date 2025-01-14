using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolBook.Web.Data;

namespace SchoolBook.Web.Controllers
{
    public class AssignmentSubmissionController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AssignmentSubmissionController(ApplicationDbContext context)
        {
            _context = context;
        }
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
    }
}
