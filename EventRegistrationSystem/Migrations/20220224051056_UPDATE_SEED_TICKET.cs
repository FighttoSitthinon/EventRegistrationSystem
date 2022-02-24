using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistrationSystem.Migrations
{
    public partial class UPDATE_SEED_TICKET : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "TicketNumber",
                table: "Tickets",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "EndDate", "Latitude", "Longitude", "Name", "StartDate", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "533FEFD0-49FF-4E7F-8A72-8CF5073A3177", "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1112), "ต้อนรับความสุขในช่วงต้นปี ด้วยการชวนทุกคนมาสัมผัสบรรยากาศสุดอบอุ่นที่ “จริงใจ มาร์เก็ต เชียงใหม่” แหล่งรวมสินค้าทำมือ อาหารพื้นเมือง และวัฒนธรรมท้องถิ่น จากพ่อกาดแม่กาดที่ตั้งอกตั้งใจสร้างสรรค์สินค้าทำมือ ปลูกผักปลอดสาร และปรุงรสอาหารพื้นเมืองให้สะอาด อร่อย เหมือนทำให้คนในครอบครัวได้อิ่มอร่อยอย่างสุขใจ", new DateTime(2022, 6, 4, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1100), 18.806058023549401, 98.996183226269395, "ช้อปงานคราฟต์ เสพงานศิลป์", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1099), 1, "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1113) },
                    { "5C8F38F5-5DFE-4F5D-8006-F9106A04A978", "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1134), "Join us in moving Thai contemporary art scene forward with Art Move: A Fundraising Exhibition for Bangkok Art and Culture Centre 2022, and acquire contemporary artworks by 49 leading Thai artists.", new DateTime(2022, 9, 12, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1129), 13.746659899999999, 100.53029960000001, "Art Move : A Fundraising Exhibition for Bangkok Art and Culture Centre 2022", new DateTime(2022, 6, 4, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1128), 1, "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1136) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name" },
                values: new object[] { "2234597B-5CA5-414E-9A49-47C5E9D1BC9D", "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 170, DateTimeKind.Utc).AddTicks(9572), "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Email", "PasswordHash", "PasswordSalt", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[] { "1F71117E-AA5B-4A55-8BA5-916AC95825F6", "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1000), "ADMIN", new byte[] { 71, 55, 243, 250, 95, 196, 120, 236, 3, 80, 236, 11, 174, 89, 202, 43, 97, 222, 127, 152, 253, 181, 16, 123, 25, 144, 128, 124, 99, 105, 176, 193 }, new byte[] { 102, 98, 52, 101, 48, 48, 49, 100, 52, 56, 100, 100, 52, 50, 54, 98, 57, 56, 98, 53, 101, 99, 98, 54, 99, 48, 57, 57, 49, 99, 50, 57 }, 1, "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Email", "EventId", "PhoneNumber", "Status", "TicketNumber", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1B83A892-06D0-4333-9E9B-7EFE159D55BE", "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1223), "test1@test01.com", "533FEFD0-49FF-4E7F-8A72-8CF5073A3177", "021234567", 1, "7D393E6F072D44C", "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1225) },
                    { "2C6482F0-CAEA-470F-8A0C-57C427B60BB4", "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1378), "test2@test02.com", "533FEFD0-49FF-4E7F-8A72-8CF5073A3177", "021256788", 1, "37C093A113E346E", "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1379) },
                    { "6A4E74FE-9930-4A1B-BECE-73BFEC01D970", "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1425), "test2@test02.com", "5C8F38F5-5DFE-4F5D-8006-F9106A04A978", "021256788", 1, "FD7BEBCDB4DD403", "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1426) },
                    { "AF8503CC-37C0-4215-A810-73D9FC3ADA11", "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1404), "test1@test01.com", "5C8F38F5-5DFE-4F5D-8006-F9106A04A978", "021234567", 1, "1E257458D8584A1", "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1405) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "RoleId", "Status", "UpdatedBy", "UpdatedDate", "UserId" },
                values: new object[] { "595B7B06-1A94-4B56-880A-161398C19491", "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1059), "2234597B-5CA5-414E-9A49-47C5E9D1BC9D", 0, "SYSTEM", new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1060), "1F71117E-AA5B-4A55-8BA5-916AC95825F6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: "1B83A892-06D0-4333-9E9B-7EFE159D55BE");

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: "2C6482F0-CAEA-470F-8A0C-57C427B60BB4");

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: "6A4E74FE-9930-4A1B-BECE-73BFEC01D970");

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: "AF8503CC-37C0-4215-A810-73D9FC3ADA11");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: "595B7B06-1A94-4B56-880A-161398C19491");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "533FEFD0-49FF-4E7F-8A72-8CF5073A3177");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "5C8F38F5-5DFE-4F5D-8006-F9106A04A978");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2234597B-5CA5-414E-9A49-47C5E9D1BC9D");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1F71117E-AA5B-4A55-8BA5-916AC95825F6");

            migrationBuilder.AlterColumn<string>(
                name: "TicketNumber",
                table: "Tickets",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

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
    }
}
