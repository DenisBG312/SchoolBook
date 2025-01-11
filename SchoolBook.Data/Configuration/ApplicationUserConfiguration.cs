using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBook.Data.Models;

namespace SchoolBook.Data.Configuration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(SeedData());
        }

        private IEnumerable<ApplicationUser> SeedData()
        {
            var user1 = new ApplicationUser()
            {
                Id = "aca001db-1d19-4354-80dc-2d646770476c",
                FirstName = "Alice",
                LastName = "Johnson",
                ProfileImgUrl = "https://img.freepik.com/free-photo/pretty-young-woman-portrait-outdoor_624325-3559.jpg",
                Email = "alice@gmail.com",
                UserName = "alice@gmail.com",
                NormalizedUserName = "ALICE@GMAIL.COM",
                NormalizedEmail = "ALICE@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = false
            };

            var user2 = new ApplicationUser()
            {
                Id = "3fcea66d-981b-4ca3-9616-43faa1838343",
                FirstName = "Bob",
                LastName = "Smith",
                ProfileImgUrl = "https://i1.sndcdn.com/avatars-pOLSo9QjSMPjQ6zF-D9J8mg-t500x500.jpg",
                Email = "bob@gmail.com",
                UserName = "bob@gmail.com",
                NormalizedUserName = "BOB@GMAIL.COM",
                NormalizedEmail = "BOB@GMAIL.COM",
                EmailConfirmed = true,
            };

            var passwordHasher = new PasswordHasher<ApplicationUser>();
            user1.PasswordHash = passwordHasher.HashPassword(user1, "Alice77!");
            user2.PasswordHash = passwordHasher.HashPassword(user2, "Bob77!");

            return new List<ApplicationUser>() { user1, user2 };
        }
    }
}
