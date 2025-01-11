using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeededApplicationUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImgUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3fcea66d-981b-4ca3-9616-43faa1838343", 0, "61ae9e18-f243-495d-97da-9a85a1794be3", "bob@gmail.com", true, "Bob", "Smith", false, null, "BOB@GMAIL.COM", "BOB@GMAIL.COM", "AQAAAAIAAYagAAAAEMlTCYEfdTnhV0s4PZGjx6su8p6PjAoRyUBQ8V8Kv1aVMcPfXxN25cNG1gnETSDQ/g==", null, false, "https://i1.sndcdn.com/avatars-pOLSo9QjSMPjQ6zF-D9J8mg-t500x500.jpg", "7de3825b-67ba-4002-a188-1cdd3fca8c57", false, "bob@gmail.com" },
                    { "aca001db-1d19-4354-80dc-2d646770476c", 0, "896e64d7-c5c3-460a-9dec-889d0d79dfc0", "alice@gmail.com", true, "Alice", "Johnson", false, null, "ALICE@GMAIL.COM", "ALICE@GMAIL.COM", "AQAAAAIAAYagAAAAED3ZqgUahF04Sq5TyOdlGui0ILMo1Ta4IQLP0QpP9DGaHUWjq2+dHuQ2wR/coZiwww==", null, false, "https://img.freepik.com/free-photo/pretty-young-woman-portrait-outdoor_624325-3559.jpg", "736a3242-0125-44ad-9e9a-2f43924adeef", false, "alice@gmail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c");
        }
    }
}
