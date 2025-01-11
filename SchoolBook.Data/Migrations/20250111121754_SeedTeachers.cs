using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedTeachers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3733e7bc-e5a3-4d32-8788-140c37db2350", "AQAAAAIAAYagAAAAEAvOQeuYuzDWGiwaygTHIUtsdeVQiVp7pMuJefd8eJZXLBk560Y2boobwCy5Xnes4w==", "64bfb24d-cbbe-4761-b153-ac3007014bb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2880d25-a52d-4d91-b580-8d71970ad815", "AQAAAAIAAYagAAAAEBL6FVS2TLJKSH8fQ8L0uG01tGUil1VwQpg0n7rb6ywOWvg2+c/93qx2S3FEGuxyyQ==", "8dd644b5-9add-4075-b4d7-3e7df342943a" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "HireDate", "Specialization", "UserId" },
                values: new object[] { "3a6372cd-7705-4af6-a2e3-0364abd8844d", new DateTime(2015, 1, 11, 14, 17, 54, 174, DateTimeKind.Local).AddTicks(5409), "Physics", "aca001db-1d19-4354-80dc-2d646770476c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61ae9e18-f243-495d-97da-9a85a1794be3", "AQAAAAIAAYagAAAAEMlTCYEfdTnhV0s4PZGjx6su8p6PjAoRyUBQ8V8Kv1aVMcPfXxN25cNG1gnETSDQ/g==", "7de3825b-67ba-4002-a188-1cdd3fca8c57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "896e64d7-c5c3-460a-9dec-889d0d79dfc0", "AQAAAAIAAYagAAAAED3ZqgUahF04Sq5TyOdlGui0ILMo1Ta4IQLP0QpP9DGaHUWjq2+dHuQ2wR/coZiwww==", "736a3242-0125-44ad-9e9a-2f43924adeef" });
        }
    }
}
