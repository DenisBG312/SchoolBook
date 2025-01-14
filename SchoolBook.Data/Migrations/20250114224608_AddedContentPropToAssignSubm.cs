using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedContentPropToAssignSubm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubmissionContent",
                table: "AssignmentsSubmissions",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d3e1778-ad28-4d88-9671-2b9fdab8cd13", "AQAAAAIAAYagAAAAEC/4LVK4k6nKDpX0y81EhE51PyGXTU7gulsA17+6Yl5EuSSh0gPs4S9ZKo6rQ1l+Qg==", "fa615605-fcc8-4a38-b31d-50117c340f58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d547f430-cf96-4abd-b135-54b69445340f", "AQAAAAIAAYagAAAAEBpmYKLqVREP5rJ7PxQ12NHfM+VilM/LP9LejX3VpR6V/2Bzasadn86i60YEnN2vUQ==", "9970d98e-c235-484f-a480-cdd9c99cb79e" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "Deadline" },
                values: new object[] { new DateTime(2025, 1, 15, 0, 46, 7, 998, DateTimeKind.Local).AddTicks(3603), new DateTime(2025, 1, 22, 0, 46, 7, 998, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "AssignmentsSubmissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SubmissionContent", "SubmissionDate" },
                values: new object[] { "This is just a demo answer to the given assignment.", new DateTime(2025, 1, 15, 0, 46, 7, 998, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                column: "AttendanceDate",
                value: new DateTime(2025, 1, 14, 0, 46, 7, 998, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExamDate",
                value: new DateTime(2025, 2, 15, 0, 46, 7, 999, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "GradedDate",
                value: new DateTime(2025, 1, 15, 0, 46, 7, 999, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                column: "EnrollmentDate",
                value: new DateTime(2024, 10, 15, 0, 46, 7, 999, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 15, 0, 46, 7, 999, DateTimeKind.Local).AddTicks(7096));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubmissionContent",
                table: "AssignmentsSubmissions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fab75318-09a5-4527-b1d0-b4a7ef450a60", "AQAAAAIAAYagAAAAENIAzlk6WDQXVEmkrJQpk7zZHe2F/Z5mK5gNfy9BDlPRwDILtlMBjm2oVTs6AOXpvg==", "87c84466-df9c-4fc9-99a3-cafda4ace666" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "859afee9-d34b-40ef-982d-28297e4b4d41", "AQAAAAIAAYagAAAAEBCtNlVUtIzbKfMHAG+Q4/lmw8DE46L95B9f2pYtQy/k34yOV5HKTYz63TxYSj1SAw==", "5913a333-bef6-4c35-8d3d-3213c21d30e0" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "Deadline" },
                values: new object[] { new DateTime(2025, 1, 13, 20, 10, 37, 883, DateTimeKind.Local).AddTicks(479), new DateTime(2025, 1, 20, 20, 10, 37, 883, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "AssignmentsSubmissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionDate",
                value: new DateTime(2025, 1, 13, 20, 10, 37, 883, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                column: "AttendanceDate",
                value: new DateTime(2025, 1, 12, 20, 10, 37, 883, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExamDate",
                value: new DateTime(2025, 2, 13, 20, 10, 37, 883, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "GradedDate",
                value: new DateTime(2025, 1, 13, 20, 10, 37, 883, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                column: "EnrollmentDate",
                value: new DateTime(2024, 10, 13, 20, 10, 37, 883, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 13, 20, 10, 37, 883, DateTimeKind.Local).AddTicks(8619));
        }
    }
}
