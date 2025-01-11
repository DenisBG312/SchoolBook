using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedExams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "ExamDate", "ExamName", "MaximumMarks", "SubjectId" },
                values: new object[] { 1, new DateTime(2025, 2, 11, 15, 5, 0, 266, DateTimeKind.Local).AddTicks(5342), "Protons and Neutrons", 100, 1 });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.UpdateData(
                table: "AssignmentsSubmissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionDate",
                value: new DateTime(2025, 1, 11, 15, 0, 40, 617, DateTimeKind.Local).AddTicks(121));

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
    }
}
