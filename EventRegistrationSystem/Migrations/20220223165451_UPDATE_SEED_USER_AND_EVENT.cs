using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistrationSystem.Migrations
{
    public partial class UPDATE_SEED_USER_AND_EVENT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Events",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "EndDate", "Latitude", "Longitude", "Name", "StartDate", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "5E03D00E-0F88-4F7C-A63D-A0763A3BB790", "SYSTEM", new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4609), "ต้อนรับความสุขในช่วงต้นปี ด้วยการชวนทุกคนมาสัมผัสบรรยากาศสุดอบอุ่นที่ “จริงใจ มาร์เก็ต เชียงใหม่” แหล่งรวมสินค้าทำมือ อาหารพื้นเมือง และวัฒนธรรมท้องถิ่น จากพ่อกาดแม่กาดที่ตั้งอกตั้งใจสร้างสรรค์สินค้าทำมือ ปลูกผักปลอดสาร และปรุงรสอาหารพื้นเมืองให้สะอาด อร่อย เหมือนทำให้คนในครอบครัวได้อิ่มอร่อยอย่างสุขใจ", new DateTime(2022, 6, 3, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4597), 18.806058023549401, 98.996183226269395, "ช้อปงานคราฟต์ เสพงานศิลป์", new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4597), 1, "SYSTEM", new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4610) },
                    { "FBF3749B-FA56-4EE7-BAA8-9B0046FE3F52", "SYSTEM", new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4615), "Join us in moving Thai contemporary art scene forward with Art Move: A Fundraising Exhibition for Bangkok Art and Culture Centre 2022, and acquire contemporary artworks by 49 leading Thai artists.", new DateTime(2022, 9, 11, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4615), 13.746659899999999, 100.53029960000001, "Art Move : A Fundraising Exhibition for Bangkok Art and Culture Centre 2022", new DateTime(2022, 6, 3, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4614), 1, "SYSTEM", new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4616) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name" },
                values: new object[] { "8E034006-5CED-4DF2-8C09-189EB890FBA2", "SYSTEM", new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(3326), "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Email", "PasswordHash", "PasswordSalt", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[] { "77705621-0CD5-4B80-80CD-61F6A66A040F", "SYSTEM", new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4514), "ADMIN", new byte[] { 44, 4, 184, 239, 99, 156, 239, 218, 156, 227, 57, 59, 149, 162, 2, 112, 181, 164, 220, 249, 170, 185, 212, 9, 126, 169, 182, 133, 31, 220, 245, 173 }, new byte[] { 102, 53, 97, 98, 99, 100, 102, 49, 55, 99, 97, 53, 52, 55, 97, 52, 57, 102, 49, 52, 50, 54, 56, 48, 56, 56, 98, 100, 48, 48, 99, 101 }, 1, "SYSTEM", new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4515) });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "RoleId", "Status", "UpdatedBy", "UpdatedDate", "UserId" },
                values: new object[] { "8AECC518-E481-48DD-9207-7F477BBB39DB", "SYSTEM", new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4573), "8E034006-5CED-4DF2-8C09-189EB890FBA2", 0, "SYSTEM", new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4573), "77705621-0CD5-4B80-80CD-61F6A66A040F" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "5E03D00E-0F88-4F7C-A63D-A0763A3BB790");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "FBF3749B-FA56-4EE7-BAA8-9B0046FE3F52");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: "8AECC518-E481-48DD-9207-7F477BBB39DB");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8E034006-5CED-4DF2-8C09-189EB890FBA2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "77705621-0CD5-4B80-80CD-61F6A66A040F");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name" },
                values: new object[] { "80E25A2D-267E-4ACF-B6F2-8908DF89ABC5", "SYSTEM", new DateTime(2022, 2, 23, 16, 31, 17, 931, DateTimeKind.Utc).AddTicks(3772), "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Email", "PasswordHash", "PasswordSalt", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[] { "0ECCCEC4-5684-4F5C-808C-C7254659ECE4", "SYSTEM", new DateTime(2022, 2, 23, 16, 31, 17, 931, DateTimeKind.Utc).AddTicks(5401), "ADMIN", new byte[] { 100, 52, 73, 66, 230, 20, 43, 55, 172, 124, 113, 199, 8, 24, 155, 129, 69, 137, 248, 51, 156, 117, 172, 79, 207, 87, 3, 183, 53, 252, 59, 155 }, new byte[] { 48, 100, 49, 55, 55, 49, 97, 56, 101, 55, 98, 49, 52, 53, 57, 102, 57, 57, 53, 49, 100, 100, 48, 57, 57, 102, 98, 101, 48, 57, 100, 57 }, 1, "SYSTEM", new DateTime(2022, 2, 23, 16, 31, 17, 931, DateTimeKind.Utc).AddTicks(5402) });
        }
    }
}
