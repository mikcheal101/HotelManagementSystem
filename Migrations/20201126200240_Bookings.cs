using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class Bookings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b8f63b5-3298-48da-b248-8cf6d6022e65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81dfc84b-4f85-4434-b664-2537a2cd5ae2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b9500eda-2901-4cde-87f5-fdf500ef7a9e", "f0d13829-ec18-4ce3-9fef-d4471035b994" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9500eda-2901-4cde-87f5-fdf500ef7a9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0d13829-ec18-4ce3-9fef-d4471035b994");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "9e618b0b-8cd4-4d24-b814-1d0cf50c55be", "9e618b0b-8cd4-4d24-b814-1d0cf50c55be", "Usertype", "system_administrator", "SYSTEM_ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "8d463df8-2772-4ff6-b3d6-9db889c77975", "8d463df8-2772-4ff6-b3d6-9db889c77975", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "5bbca874-0d71-45fb-bcc1-81dc7cc465e0", "5bbca874-0d71-45fb-bcc1-81dc7cc465e0", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aa5a3778-46a7-49e2-b033-beed3c09e494", 0, "6e3e7c4b-6b49-4ea3-ba87-bb2138d63108", "Person", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEMjcjWr77tE+vbb3becCFxWbJLh5xQo3pTzLJKPNg2eBBzoZTgLGlneAGw075Jx2RQ==", null, "07020464737", true, "e9ef95a4-2718-422b-b3f6-e312fb0b2257", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9e618b0b-8cd4-4d24-b814-1d0cf50c55be", "aa5a3778-46a7-49e2-b033-beed3c09e494" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bbca874-0d71-45fb-bcc1-81dc7cc465e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d463df8-2772-4ff6-b3d6-9db889c77975");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e618b0b-8cd4-4d24-b814-1d0cf50c55be", "aa5a3778-46a7-49e2-b033-beed3c09e494" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e618b0b-8cd4-4d24-b814-1d0cf50c55be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5a3778-46a7-49e2-b033-beed3c09e494");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "b9500eda-2901-4cde-87f5-fdf500ef7a9e", "b9500eda-2901-4cde-87f5-fdf500ef7a9e", "Usertype", "system_administrator", "SYSTEM_ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "81dfc84b-4f85-4434-b664-2537a2cd5ae2", "81dfc84b-4f85-4434-b664-2537a2cd5ae2", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "2b8f63b5-3298-48da-b248-8cf6d6022e65", "2b8f63b5-3298-48da-b248-8cf6d6022e65", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f0d13829-ec18-4ce3-9fef-d4471035b994", 0, "17a58171-5c05-4241-a0b0-9666c8a06809", "Person", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAELiJ3kmPTYigKYNGJRu9/48iTaYm53s0N1yMhVBAVuRYCwh0PXOR4Sy9PU9jAjylRQ==", null, "07020464737", true, "1f586144-dd14-4c18-a777-21461c25e3f7", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b9500eda-2901-4cde-87f5-fdf500ef7a9e", "f0d13829-ec18-4ce3-9fef-d4471035b994" });
        }
    }
}
