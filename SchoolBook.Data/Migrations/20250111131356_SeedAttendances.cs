using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAttendances : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "006ee67a-c9b1-4d98-a0c1-a861f56b0b09", "AQAAAAIAAYagAAAAELtuaE7c3p9Y3oFG19ah9EyVTVS5GLFdOvITA7R8a1U6XajOru1RbukWXXhdlzq0mw==", "91a69c42-03cf-470c-9176-1f8afb29e43f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0859ad4c-4265-487c-8a52-5ed6ca947088", "AQAAAAIAAYagAAAAEIpQVZViHEmPyfVciqNN8sYfK+D+6TtLChQMAPefYtwJNX+a23MdWlDHbRncUHv8uQ==", "027b835c-5e8d-46bf-abc9-a57c3c93c6b0" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "Deadline" },
                values: new object[] { new DateTime(2025, 1, 11, 15, 13, 55, 769, DateTimeKind.Local).AddTicks(2305), new DateTime(2025, 1, 18, 15, 13, 55, 769, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "AssignmentsSubmissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionDate",
                value: new DateTime(2025, 1, 11, 15, 13, 55, 769, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "ClassId", "IsPresent", "StudentId" },
                values: new object[] { 1, new DateTime(2025, 1, 10, 15, 13, 55, 769, DateTimeKind.Local).AddTicks(4954), 1, false, "15713fda-d8ba-47fc-b70b-4cdf170fc78d" });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExamDate",
                value: new DateTime(2025, 2, 11, 15, 13, 55, 769, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "GradedDate",
                value: new DateTime(2025, 1, 11, 15, 13, 55, 769, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                column: "EnrollmentDate",
                value: new DateTime(2024, 10, 11, 15, 13, 55, 769, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 11, 15, 13, 55, 770, DateTimeKind.Local).AddTicks(4327));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83f1eb77-1de3-44ed-9cf1-ccd51e648090", "AQAAAAIAAYagAAAAEL+/P5n76w9JoZgRg++P3pJ4bfCUmW3miAVACiR/Gz6CE6hXGKnz9TwSv6skiOGDQg==", "51303d61-57e2-42af-a103-05dd0650a7ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f0cb2a5-b1ed-46ab-992e-c97ed3d91432", "AQAAAAIAAYagAAAAENdUX4A4E6+4vM3i7uhFOdmkU3OTnJaZSux8I0hNodmxq78RcH9TtJFpX+mBCVCX1w==", "dd1ac021-2f08-4051-a1bb-c998155a3ecb" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "Deadline" },
                values: new object[] { new DateTime(2025, 1, 11, 15, 10, 17, 957, DateTimeKind.Local).AddTicks(7721), new DateTime(2025, 1, 18, 15, 10, 17, 957, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "AssignmentsSubmissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionDate",
                value: new DateTime(2025, 1, 11, 15, 10, 17, 958, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExamDate",
                value: new DateTime(2025, 2, 11, 15, 10, 17, 958, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "GradedDate",
                value: new DateTime(2025, 1, 11, 15, 10, 17, 958, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                column: "EnrollmentDate",
                value: new DateTime(2024, 10, 11, 15, 10, 17, 958, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 11, 15, 10, 17, 959, DateTimeKind.Local).AddTicks(988));
        }
    }
}
