using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistrationSystem.Migrations
{
    public partial class ADDSEED : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name" },
                values: new object[] { "3B63141A-AB48-446C-BA27-271FBF9E3553", "SYSTEM", new DateTime(2022, 2, 23, 16, 24, 1, 693, DateTimeKind.Utc).AddTicks(2241), "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3B63141A-AB48-446C-BA27-271FBF9E3553");
        }
    }
}
