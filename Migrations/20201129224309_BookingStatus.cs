using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class BookingStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5769fc2a-b18a-45b8-ae17-7cf2ba01a80b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf50efe5-3940-48ed-b187-23cea92dcf32");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f0ac7fd8-3843-4cee-90e7-0240d4620924", "26c61922-c53f-4b66-9ddb-55752bdc7a3b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0ac7fd8-3843-4cee-90e7-0240d4620924");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26c61922-c53f-4b66-9ddb-55752bdc7a3b");

            migrationBuilder.AddColumn<string>(
                name: "RoomStatus",
                table: "Bookings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "ecb23ae9-674d-46f7-bae7-9bffd0d2681a", "ecb23ae9-674d-46f7-bae7-9bffd0d2681a", "Usertype", "system_administrator", "SYSTEM_ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "381f4114-f5ef-4079-afcc-1aa99012dd6e", "381f4114-f5ef-4079-afcc-1aa99012dd6e", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "40b662c5-138d-4b1e-9fa0-f8a074391252", "40b662c5-138d-4b1e-9fa0-f8a074391252", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b6d00956-a20b-4a67-8796-8f5b50ad900c", 0, "459b9bbc-2a03-4136-963f-5495df34ff99", "Person", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAECIAOhjqwLPK2aC97RxYFqyBHZ8B+dcWlVubty174551vW1wR/0s7k6m1XQkdzjFHw==", null, "07020464737", true, "a52e1006-857c-4ced-b2f1-c7f63932c40a", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ecb23ae9-674d-46f7-bae7-9bffd0d2681a", "b6d00956-a20b-4a67-8796-8f5b50ad900c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381f4114-f5ef-4079-afcc-1aa99012dd6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40b662c5-138d-4b1e-9fa0-f8a074391252");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb23ae9-674d-46f7-bae7-9bffd0d2681a", "b6d00956-a20b-4a67-8796-8f5b50ad900c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecb23ae9-674d-46f7-bae7-9bffd0d2681a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6d00956-a20b-4a67-8796-8f5b50ad900c");

            migrationBuilder.DropColumn(
                name: "RoomStatus",
                table: "Bookings");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "f0ac7fd8-3843-4cee-90e7-0240d4620924", "f0ac7fd8-3843-4cee-90e7-0240d4620924", "Usertype", "system_administrator", "SYSTEM_ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "5769fc2a-b18a-45b8-ae17-7cf2ba01a80b", "5769fc2a-b18a-45b8-ae17-7cf2ba01a80b", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "bf50efe5-3940-48ed-b187-23cea92dcf32", "bf50efe5-3940-48ed-b187-23cea92dcf32", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "26c61922-c53f-4b66-9ddb-55752bdc7a3b", 0, "368cf53f-0e40-4a20-b40e-70e214739814", "Person", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEBVcsr5rCYllU0NkIKpBsYUZk1IUrDULb5gy3cXMHs3aiZxjUzdamnNY5M4jLKPjIQ==", null, "07020464737", true, "fdcb70e1-0fc5-4892-83fd-66156ff124c4", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f0ac7fd8-3843-4cee-90e7-0240d4620924", "26c61922-c53f-4b66-9ddb-55752bdc7a3b" });
        }
    }
}
