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
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.HasData(SeedData());
        }

        private IEnumerable<Class> SeedData()
        {
            var classes = new List<Class>()
            {
                new Class()
                {
                    Id = 1,
                    TeacherId = "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                    ClassName = "11 A",
                    GradeLevel = "11",
                    Schedule = "Monday to Friday 10 AM - 11 AM",
                }
            };

            return classes;
        }
    }
}
