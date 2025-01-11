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
    public class Subjects : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasData(SeedData());
        }

        private IEnumerable<Subject> SeedData()
        {
            var subjects = new List<Subject>()
            {
                new Subject()
                {
                    Id = 1,
                    ClassId = 1,
                    TeacherId = "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                    SubjectName = "Physics and Astronomy"
                }
            };

            return subjects;
        }
    }
}
