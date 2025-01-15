using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBook.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Data.Configuration
{
    public class AssignmentClassConfiguration : IEntityTypeConfiguration<AssignmentClass>
    {
        public void Configure(EntityTypeBuilder<AssignmentClass> builder)
        {
            builder.HasData(SeedData());
        }

        private IEnumerable<AssignmentClass> SeedData()
        {
            var examClasses = new List<AssignmentClass>()
            {
                new AssignmentClass()
                {
                    AssignmentId = 1,
                    ClassId = 1
                }
            };

            return examClasses;
        }
    }
}
