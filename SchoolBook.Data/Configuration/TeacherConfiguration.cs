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
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(SeedData());
        }

        private IEnumerable<Teacher> SeedData()
        {
            var teachers = new List<Teacher>()
            {
                new Teacher()
                {
                    Id = "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                    Specialization = "Physics",
                    HireDate = DateTime.Now.AddYears(-10),
                    UserId = "aca001db-1d19-4354-80dc-2d646770476c"
                }
            };

            return teachers;
        }
    }
}
