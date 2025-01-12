using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolBook.Web.Data;

namespace SchoolBook.Web.Controllers
{
	public class AssignmentsController : Controller
	{
		private ApplicationDbContext _context;
		public AssignmentsController(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var assignments = await _context.Assignments.ToListAsync();

			return View(assignments);
		}
	}
}
