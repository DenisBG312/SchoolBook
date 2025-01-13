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
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasData(SeedData());
        }

        private IEnumerable<Assignment> SeedData()
        {
            var assignments = new List<Assignment>()
            {
                new Assignment()
                {
                    Id = 1,
                    Title = "Physics Homework",
                    AssignedDate = DateTime.Now,
                    Deadline = DateTime.Now.AddDays(7),
                    SubjectId = 1,
                    Description = "Is the sun a star or a planet? Write your answers below.",
                    ClassId = 1
                }
            };

            return assignments;
        }
    }
}
