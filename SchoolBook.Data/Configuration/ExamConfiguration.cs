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
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasData(SeedData());
        }

        private IEnumerable<Exam> SeedData()
        {
            var exams = new List<Exam>()
            {
                new Exam()
                {
                    Id = 1,
                    ExamDate = DateTime.Now.AddMonths(1),
                    SubjectId = 1,
                    ExamName = "Protons and Neutrons",
                    MaximumMarks = 100
                }
            };

            return exams;
        }
    }
}
