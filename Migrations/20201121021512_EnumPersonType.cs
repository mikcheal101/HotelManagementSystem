using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class EnumPersonType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "391b66c8-dd80-460c-aaa5-dfd0e8df6d3e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "81d75c32-b89a-48bc-9c02-deebba2ecc45", 0, "209a0e11-5a3c-47c8-85d2-c43a38246200", "admin@mail.com", true, "Hassan", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEGzcBUoZqp5F1y99vxWAuzYRpngnVgWlvqo/7jP3dGl2+1FhmrQMI0/hfARgpOdHbg==", "07020464737", true, "f6803bf2-d377-4c69-8b2a-a4609cb2ea4c", false, "admin@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81d75c32-b89a-48bc-9c02-deebba2ecc45");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "391b66c8-dd80-460c-aaa5-dfd0e8df6d3e", 0, "76e5164f-ea65-484d-840e-bfb7f1ac1a99", "admin@mail.com", true, "Hassan", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEDyo6kiaejllLAV1hBhBd8b2zJi6qgGY1oj4HumkWYqGVhWGMnyNpBSlcayU8dRsOA==", "07020464737", true, "57cc1831-ef51-47a3-815b-5585e84a1369", false, "admin@mail.com" });
        }
    }
}
