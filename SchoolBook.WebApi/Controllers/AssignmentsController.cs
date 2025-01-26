using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolBook.Web.Data;
using SchoolBook.WebApi.Dtos.Assignment;
using SchoolBook.WebApi.Dtos.AssignmentClass;
using SchoolBook.WebApi.Dtos.Submission;

namespace SchoolBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AssignmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var assignments = await _context.Assignments
                .Include(x => x.AssignmentClasses)
                .Include(x => x.Subject)
                .Include(x => x.Submissions)
                .Select(a => new GetAssignmentsDto()
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                    AssignedDate = a.AssignedDate,
                    Deadline = a.Deadline,
                    SubjectId = a.Subject.Id,
                    SubjectName = a.Subject.SubjectName,
                    AssignmentClasses = a.AssignmentClasses
                        .Select(ac => new AssignmentClassDto()
                        {
                            Id = ac.Class.Id,
                            ClassName = ac.Class.ClassName
                        }).ToList(),
                    Submissions = a.Submissions.Select(s => new SubmissionDto()
                    {
                        Id = s.Id,
                        StudentName = $"{s.Student.User.FirstName} {s.Student.User.LastName}"
                    }).ToList()
                })
                .ToListAsync();

            return Ok(assignments);
        }
    }
}
