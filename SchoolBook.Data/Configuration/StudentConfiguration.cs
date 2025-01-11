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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(SeedData());
        }

        private IEnumerable<Student> SeedData()
        {
            var students = new List<Student>()
            {
                new Student()
                {
                    Id = "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                    Address = "Ruse, Drujba 1",
                    EnrollmentDate = DateTime.Now.AddMonths(-3),
                    ParentContact = "Mother's phone: +359888888888",
                    UserId = "3fcea66d-981b-4ca3-9616-43faa1838343",
                    ClassId = 1,
                }
            };

            return students;
        }
    }
}
