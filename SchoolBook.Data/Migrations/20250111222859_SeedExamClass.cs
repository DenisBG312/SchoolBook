using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedExamClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66d030f6-a088-48ce-a4f2-11cd0c471621", "AQAAAAIAAYagAAAAELZ8Fx4Lu6Jk3IPlcgFWnBK6z780L0a4h0lebTJAip2gBlfamyqm27j4tUoXNEu5Rw==", "52a1c5f3-eb5e-4006-baed-57f6c535b877" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4545fe58-b3b5-469c-bb16-0edcb7507503", "AQAAAAIAAYagAAAAEGJ48a+Lf1P3NblVTqHkYy3/kgVxae02b3NM5T9VfUB+r19iluJO8OP3JfM5DrjMZg==", "e11833fd-1972-4f3e-91a4-22f8b045521f" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "Deadline" },
                values: new object[] { new DateTime(2025, 1, 12, 0, 28, 59, 87, DateTimeKind.Local).AddTicks(4746), new DateTime(2025, 1, 19, 0, 28, 59, 87, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "AssignmentsSubmissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionDate",
                value: new DateTime(2025, 1, 12, 0, 28, 59, 87, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                column: "AttendanceDate",
                value: new DateTime(2025, 1, 11, 0, 28, 59, 87, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.InsertData(
                table: "ExamClasses",
                columns: new[] { "ClassId", "ExamId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExamDate",
                value: new DateTime(2025, 2, 12, 0, 28, 59, 87, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "GradedDate",
                value: new DateTime(2025, 1, 12, 0, 28, 59, 88, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                column: "EnrollmentDate",
                value: new DateTime(2024, 10, 12, 0, 28, 59, 88, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 12, 0, 28, 59, 88, DateTimeKind.Local).AddTicks(2916));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExamClasses",
                keyColumns: new[] { "ClassId", "ExamId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c03dcc6b-d9c2-4897-b3a7-8438a55d2ba3", "AQAAAAIAAYagAAAAEHXrsXvcC1C1JQFebP63qU4CKYyOFjPegfiBeLhGTPL+QuF5XhSPIy28qq+GMvRnrA==", "481b9295-188a-4290-9c59-9e8b3eed56aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cf7f46a-a1fc-499e-8507-dd416f7065b3", "AQAAAAIAAYagAAAAEENMryBKHyf6YN5K4CPaIYYxmAYdCWtSm/wJGkeQx7SD6hxaGuQVQx4trPjTHHZJkw==", "9ba5f3b1-c998-4d38-8c25-ab630f27591d" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "Deadline" },
                values: new object[] { new DateTime(2025, 1, 12, 0, 23, 4, 476, DateTimeKind.Local).AddTicks(7418), new DateTime(2025, 1, 19, 0, 23, 4, 476, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "AssignmentsSubmissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionDate",
                value: new DateTime(2025, 1, 12, 0, 23, 4, 476, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                column: "AttendanceDate",
                value: new DateTime(2025, 1, 11, 0, 23, 4, 476, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExamDate",
                value: new DateTime(2025, 2, 12, 0, 23, 4, 477, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "GradedDate",
                value: new DateTime(2025, 1, 12, 0, 23, 4, 477, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                column: "EnrollmentDate",
                value: new DateTime(2024, 10, 12, 0, 23, 4, 477, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 12, 0, 23, 4, 477, DateTimeKind.Local).AddTicks(6180));
        }
    }
}
