using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class MadeAssignmentsAndClassConnected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Assignments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "AssignedDate", "ClassId", "Deadline" },
                values: new object[] { new DateTime(2025, 1, 13, 20, 10, 37, 883, DateTimeKind.Local).AddTicks(479), 1, new DateTime(2025, 1, 20, 20, 10, 37, 883, DateTimeKind.Local).AddTicks(480) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ClassId",
                table: "Assignments",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Classes_ClassId",
                table: "Assignments",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Classes_ClassId",
                table: "Assignments");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_ClassId",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Assignments");

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
    }
}
