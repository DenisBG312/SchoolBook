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
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasData(SeedData());
        }

        private IEnumerable<Grade> SeedData()
        {
            var grades = new List<Grade>()
            {
                new Grade()
                {
                    Id = 1,
                    StudentId = "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                    Comment = "Keep up the excellent job Bob!",
                    EvaluationName = "Excellent 6",
                    GradedDate = DateTime.Now,
                    ExamId = 1
                }
            };

            return grades;
        }
    }
}
