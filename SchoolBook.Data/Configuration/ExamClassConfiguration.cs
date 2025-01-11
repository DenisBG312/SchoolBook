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
    public class ExamClassConfiguration : IEntityTypeConfiguration<ExamClass>
    {
        public void Configure(EntityTypeBuilder<ExamClass> builder)
        {
            builder.HasData(SeedData());
        }

        private IEnumerable<ExamClass> SeedData()
        {
            var examClasses = new List<ExamClass>()
            {
                new ExamClass()
                {
                    ClassId = 1,
                    ExamId = 1
                }
            };

            return examClasses;
        }
    }
}
