using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedGrades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Exams_ExamId",
                table: "Grades");

            migrationBuilder.AlterColumn<int>(
                name: "ExamId",
                table: "Grades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "Comment", "EvaluationName", "ExamId", "GradedDate", "StudentId" },
                values: new object[] { 1, "Keep up the excellent job Bob!", "Excellent 6", 1, new DateTime(2025, 1, 11, 15, 10, 17, 958, DateTimeKind.Local).AddTicks(6447), "15713fda-d8ba-47fc-b70b-4cdf170fc78d" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Exams_ExamId",
                table: "Grades",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Exams_ExamId",
                table: "Grades");

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "ExamId",
                table: "Grades",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3313b53b-a03b-4f91-b0e6-3e104cb34d77", "AQAAAAIAAYagAAAAEF414K6QlWyAXvrV0t87Caj90023bkHn7nwVxNZ91uDVGz9zP0mpg1sxayrR1nBQkg==", "d81bc5e4-0728-4535-b901-44cdbaabb218" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9b2f1c9-1d53-4d2c-a982-5aa98792a30d", "AQAAAAIAAYagAAAAEHSVnMK6kajUxcvqRAuUPcHEfwZgdfUgf8JWGf88GSV7oPDV9kjLPfeyFvuz1mT/Hw==", "a0e3f827-b1c7-45cb-bd1c-b53ccfb8d532" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "Deadline" },
                values: new object[] { new DateTime(2025, 1, 11, 15, 5, 0, 266, DateTimeKind.Local).AddTicks(2343), new DateTime(2025, 1, 18, 15, 5, 0, 266, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "AssignmentsSubmissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionDate",
                value: new DateTime(2025, 1, 11, 15, 5, 0, 266, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExamDate",
                value: new DateTime(2025, 2, 11, 15, 5, 0, 266, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                column: "EnrollmentDate",
                value: new DateTime(2024, 10, 11, 15, 5, 0, 266, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 11, 15, 5, 0, 266, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Exams_ExamId",
                table: "Grades",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");
        }
    }
}
