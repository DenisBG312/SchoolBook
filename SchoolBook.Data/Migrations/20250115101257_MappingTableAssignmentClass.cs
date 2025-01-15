using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class MappingTableAssignmentClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AssignmentClasses",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentClasses", x => new { x.AssignmentId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_AssignmentClasses_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentClasses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11158200-ed65-4e1d-8d23-e336a03c6c33", "AQAAAAIAAYagAAAAEI8kugjZn6tibNNTZV0xvTd2aeLAC4SJGeyH0r5f3bFqIIFpIhOEuptc/IjKblsqjg==", "b3cdd9af-9069-41e9-93d2-69584514ce5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6f86830-44eb-44c5-ae05-5481c46116f3", "AQAAAAIAAYagAAAAEHHuRVOSaFc/ZoxOnca/S2X4bXbnJfMoyutRRjKKMs8VxCBQUSTwUJjzvsGKqLP08A==", "a753ff02-e18a-469e-9ada-a169fbf448b5" });

            migrationBuilder.InsertData(
                table: "AssignmentClasses",
                columns: new[] { "AssignmentId", "ClassId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "Deadline" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 12, 56, 545, DateTimeKind.Local).AddTicks(7454), new DateTime(2025, 1, 22, 12, 12, 56, 545, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "AssignmentsSubmissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionDate",
                value: new DateTime(2025, 1, 15, 12, 12, 56, 545, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                column: "AttendanceDate",
                value: new DateTime(2025, 1, 14, 12, 12, 56, 545, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExamDate",
                value: new DateTime(2025, 2, 15, 12, 12, 56, 545, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "GradedDate",
                value: new DateTime(2025, 1, 15, 12, 12, 56, 545, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                column: "EnrollmentDate",
                value: new DateTime(2024, 10, 15, 12, 12, 56, 546, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 15, 12, 12, 56, 546, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentClasses_ClassId",
                table: "AssignmentClasses",
                column: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignmentClasses");

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
                columns: new[] { "AssignedDate", "ClassId", "Deadline" },
                values: new object[] { new DateTime(2025, 1, 15, 0, 46, 7, 998, DateTimeKind.Local).AddTicks(3603), 1, new DateTime(2025, 1, 22, 0, 46, 7, 998, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "AssignmentsSubmissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionDate",
                value: new DateTime(2025, 1, 15, 0, 46, 7, 998, DateTimeKind.Local).AddTicks(4950));

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
