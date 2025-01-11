using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassName", "GradeLevel", "Schedule", "TeacherId" },
                values: new object[] { 1, "11 A", "11", "Monday to Friday 10 AM - 11 AM", "3a6372cd-7705-4af6-a2e3-0364abd8844d" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 11, 14, 25, 44, 186, DateTimeKind.Local).AddTicks(8244));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcea66d-981b-4ca3-9616-43faa1838343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3733e7bc-e5a3-4d32-8788-140c37db2350", "AQAAAAIAAYagAAAAEAvOQeuYuzDWGiwaygTHIUtsdeVQiVp7pMuJefd8eJZXLBk560Y2boobwCy5Xnes4w==", "64bfb24d-cbbe-4761-b153-ac3007014bb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca001db-1d19-4354-80dc-2d646770476c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2880d25-a52d-4d91-b580-8d71970ad815", "AQAAAAIAAYagAAAAEBL6FVS2TLJKSH8fQ8L0uG01tGUil1VwQpg0n7rb6ywOWvg2+c/93qx2S3FEGuxyyQ==", "8dd644b5-9add-4075-b4d7-3e7df342943a" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3a6372cd-7705-4af6-a2e3-0364abd8844d",
                column: "HireDate",
                value: new DateTime(2015, 1, 11, 14, 17, 54, 174, DateTimeKind.Local).AddTicks(5409));
        }
    }
}
