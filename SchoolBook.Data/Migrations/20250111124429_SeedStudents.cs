using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Students",
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
                values: new object[] { "a0c5b4ab-1d2a-4915-acb9-8bae1ef24eb5", "AQAAAAIAAYagAAAAEBSqQJm9FDxenPpMrM3HQfopXR0syz27doXnTpYTJv7g7joBSOgWcAhSYobHEBVvcA==", "0b360f47-8451-433e-b2c3-17ff793dfd09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce64fe7f-b645-4db0-879b-652574e67c91", "AQAAAAIAAYagAAAAEDL/pGz+YtvihanoLbuIABWfRa4Xlj/VeNzjBc08tlRwNp3b5l3GArUyeDyJfTal3A==", "6a17357c-6546-44f0-8ae7-09b6dcb1b3e5" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "ClassId", "EnrollmentDate", "ParentContact", "UserId" },
                values: new object[] { "15713fda-d8ba-47fc-b70b-4cdf170fc78d", "Ruse, Drujba 1", 1, new DateTime(2024, 10, 11, 14, 44, 28, 732, DateTimeKind.Local).AddTicks(2632), "Mother's phone: +359888888888", "3fcea66d-981b-4ca3-9616-43faa1838343" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 11, 14, 44, 28, 732, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15713fda-d8ba-47fc-b70b-4cdf170fc78d");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33dbd930-7aaa-409c-b86f-d0c1bca6ab2a", "AQAAAAIAAYagAAAAED6AE2TTGBAMOmJbF1WD8FcYhHnlWfUC1yUfpiGfwL39dgbx6qMDHtRcUcxlwCxnLw==", "69052dc5-3235-48ef-89ec-1d6b7f831c06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3ea81da-aa0f-4327-b3b4-bf017ea61acd", "AQAAAAIAAYagAAAAEFKkDT11gnrnKlZ19q87eVMA84BWpAQOmajy4qjOJa/ixUDuJu0w146GQqDFxvWWUg==", "007093e4-9117-47e1-8e51-9ae7ee795760" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 11, 14, 25, 44, 186, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");
        }
    }
}
