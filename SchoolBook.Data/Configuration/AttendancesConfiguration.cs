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
    public class AttendancesConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasData(SeedData());
        }

        private IEnumerable<Attendance> SeedData()
        {
            var attendances = new List<Attendance>()
            {
                new Attendance()
                {
                    Id = 1,
                    ClassId = 1,
                    StudentId = "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                    AttendanceDate = DateTime.Now.AddDays(-1),
                    IsPresent = false
                }
            };

            return attendances;
        }
    }
}
