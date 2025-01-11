using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAssignments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e35aa015-294d-4c14-a3c1-a9699b9c4203", "AQAAAAIAAYagAAAAEPPKFIqrlLszNcO283ryg1ondONS5mDor9XsHca+wpNINegMDZLSqC1SWwmJHrCcdw==", "b2ce41d6-605d-430b-9235-90c3311b6d77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5941815-8b0b-471e-9df8-810ed19a0a65", "AQAAAAIAAYagAAAAEAUU3Qti32SnCg7RCWUyqVhCTMqFwz0WoppuuLxFqIwYzoKlPj7tZxbs0FsiT6Hl9g==", "3dc68245-bb1e-43f0-96f8-cdf77b093b70" });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "AssignedDate", "Deadline", "Description", "SubjectId", "Title" },
                values: new object[] { 1, new DateTime(2025, 1, 11, 14, 54, 39, 602, DateTimeKind.Local).AddTicks(6833), new DateTime(2025, 1, 18, 14, 54, 39, 602, DateTimeKind.Local).AddTicks(6835), "Is the sun a star or a planet? Write your answers below.", 1, "Physics Homework" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                column: "EnrollmentDate",
                value: new DateTime(2024, 10, 11, 14, 54, 39, 602, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 11, 14, 54, 39, 603, DateTimeKind.Local).AddTicks(907));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8548a104-7baf-40cd-830f-853d2a7fdc5b", "AQAAAAIAAYagAAAAEPQ68Q5Us2DWVH0lb4jeOw2eW5qgt+BOkH73cj2nORt1Bv7X0//JzrH7IOdBuSl5GA==", "8cf16688-7865-435c-8b79-2e75c13f7413" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7688001d-78e6-4655-9a0e-e9430da6f860", "AQAAAAIAAYagAAAAEDMWwKB3am968I6NHrOt4gn86pcIJSvq7fSQW0fERtsQ2D/ob8FDctqq+ZfxO79oEg==", "8f198f0f-5e3f-4768-ac54-82ba2e5d8e4a" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                column: "EnrollmentDate",
                value: new DateTime(2024, 10, 11, 14, 49, 8, 517, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 11, 14, 49, 8, 517, DateTimeKind.Local).AddTicks(5553));
        }
    }
}
