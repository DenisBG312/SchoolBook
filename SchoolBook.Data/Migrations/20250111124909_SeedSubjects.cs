using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedSubjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "ClassId", "SubjectName", "TeacherId" },
                values: new object[] { 1, 1, "Physics and Astronomy", "3a6372cd-7705-4af6-a2e3-0364abd8844d" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 11, 14, 49, 8, 517, DateTimeKind.Local).AddTicks(5553));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0c5b4ab-1d2a-4915-acb9-8bae1ef24eb5", "AQAAAAIAAYagAAAAEBSqQJm9FDxenPpMrM3HQfopXR0syz27doXnTpYTJv7g7joBSOgWcAhSYobHEBVvcA==", "0b360f47-8451-433e-b2c3-17ff793dfd09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce64fe7f-b645-4db0-879b-652574e67c91", "AQAAAAIAAYagAAAAEDL/pGz+YtvihanoLbuIABWfRa4Xlj/VeNzjBc08tlRwNp3b5l3GArUyeDyJfTal3A==", "6a17357c-6546-44f0-8ae7-09b6dcb1b3e5" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15713fda-d8ba-47fc-b70b-4cdf170fc78d",
                column: "EnrollmentDate",
                value: new DateTime(2024, 10, 11, 14, 44, 28, 732, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 11, 14, 44, 28, 732, DateTimeKind.Local).AddTicks(4117));
        }
    }
}
