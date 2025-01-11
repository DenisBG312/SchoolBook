using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAssignmentSubmissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a17af3b2-61a3-4243-8e03-665f96a578a8", "AQAAAAIAAYagAAAAEN3nQMvjQbbbOjBs9aKpGbWOeaBuGKRmTVQoyq5Q6suGONexJNwFvcMKNwGbUNxNyw==", "4a9dd6d4-b141-46fc-a3f1-ab17fc400cc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b96e778-7f32-47a8-9e15-c8db3a29a0c4", "AQAAAAIAAYagAAAAEBuF0mIqdPAHrt9bsbRSb46O9/MWOKUe54Ya6wIH6o938WRLQqDtEysTkvgF6291yA==", "c159b710-b4b2-4448-966d-3afecff7b830" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "Deadline" },
                values: new object[] { new DateTime(2025, 1, 11, 15, 0, 40, 616, DateTimeKind.Local).AddTicks(9021), new DateTime(2025, 1, 18, 15, 0, 40, 616, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.InsertData(
                table: "AssignmentsSubmissions",
                columns: new[] { "Id", "AssignmentId", "Feedback", "MarksObtained", "StudentId", "SubmissionDate" },
                values: new object[] { 1, 1, null, 90, "15713fda-d8ba-47fc-b70b-4cdf170fc78d", new DateTime(2025, 1, 11, 15, 0, 40, 617, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                column: "EnrollmentDate",
                value: new DateTime(2024, 10, 11, 15, 0, 40, 617, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 11, 15, 0, 40, 617, DateTimeKind.Local).AddTicks(4023));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssignmentsSubmissions",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "Deadline" },
                values: new object[] { new DateTime(2025, 1, 11, 14, 54, 39, 602, DateTimeKind.Local).AddTicks(6833), new DateTime(2025, 1, 18, 14, 54, 39, 602, DateTimeKind.Local).AddTicks(6835) });

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
    }
}
