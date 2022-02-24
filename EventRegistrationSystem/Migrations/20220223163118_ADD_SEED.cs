using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistrationSystem.Migrations
{
    public partial class ADD_SEED : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3B63141A-AB48-446C-BA27-271FBF9E3553");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name" },
                values: new object[] { "80E25A2D-267E-4ACF-B6F2-8908DF89ABC5", "SYSTEM", new DateTime(2022, 2, 23, 16, 31, 17, 931, DateTimeKind.Utc).AddTicks(3772), "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Email", "PasswordHash", "PasswordSalt", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[] { "0ECCCEC4-5684-4F5C-808C-C7254659ECE4", "SYSTEM", new DateTime(2022, 2, 23, 16, 31, 17, 931, DateTimeKind.Utc).AddTicks(5401), "ADMIN", new byte[] { 100, 52, 73, 66, 230, 20, 43, 55, 172, 124, 113, 199, 8, 24, 155, 129, 69, 137, 248, 51, 156, 117, 172, 79, 207, 87, 3, 183, 53, 252, 59, 155 }, new byte[] { 48, 100, 49, 55, 55, 49, 97, 56, 101, 55, 98, 49, 52, 53, 57, 102, 57, 57, 53, 49, 100, 100, 48, 57, 57, 102, 98, 101, 48, 57, 100, 57 }, 1, "SYSTEM", new DateTime(2022, 2, 23, 16, 31, 17, 931, DateTimeKind.Utc).AddTicks(5402) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "80E25A2D-267E-4ACF-B6F2-8908DF89ABC5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0ECCCEC4-5684-4F5C-808C-C7254659ECE4");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name" },
                values: new object[] { "3B63141A-AB48-446C-BA27-271FBF9E3553", "SYSTEM", new DateTime(2022, 2, 23, 16, 24, 1, 693, DateTimeKind.Utc).AddTicks(2241), "ADMIN" });
        }
    }
}
