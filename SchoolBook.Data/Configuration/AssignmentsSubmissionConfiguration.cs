using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBook.Data.Models;

namespace SchoolBook.Data.Configuration
{
    public class AssignmentsSubmissionConfiguration : IEntityTypeConfiguration<AssignmentSubmission>
    {
        public void Configure(EntityTypeBuilder<AssignmentSubmission> builder)
        {
            builder.HasData(SeedData());
        }

        private IEnumerable<AssignmentSubmission> SeedData()
        {
            var submissions = new List<AssignmentSubmission>()
            {
                new AssignmentSubmission()
                {
                    Id = 1,
                    SubmissionDate = DateTime.Now,
                    StudentId = "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                    AssignmentId = 1,
                    MarksObtained = 90,
                    Feedback = null,
                }
            };

            return submissions;
        }
    }
}
