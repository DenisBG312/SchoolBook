using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedMappingTableBetweenExamClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamClasses",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamClasses", x => new { x.ExamId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_ExamClasses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamClasses_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ExamClasses_ClassId",
                table: "ExamClasses",
                column: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamClasses");

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

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                column: "AttendanceDate",
                value: new DateTime(2025, 1, 10, 15, 13, 55, 769, DateTimeKind.Local).AddTicks(4954));

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
    }
}
