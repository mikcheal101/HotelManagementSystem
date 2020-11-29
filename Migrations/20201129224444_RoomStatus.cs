using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class RoomStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "RoomStatus",
                table: "Rooms",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "b7e48780-4f88-4b7c-8ae4-89d7d9cc4104", "b7e48780-4f88-4b7c-8ae4-89d7d9cc4104", "Usertype", "system_administrator", "SYSTEM_ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "2a08f7bc-2add-444f-93d2-1b25c1c9d21f", "2a08f7bc-2add-444f-93d2-1b25c1c9d21f", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "ce0ab11d-f63e-42f0-92dd-b4d4bd9bf637", "ce0ab11d-f63e-42f0-92dd-b4d4bd9bf637", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b28e2b12-8802-4f17-ae6a-40064ed260d1", 0, "a61d8a17-41d8-4f5c-a85e-7d1157ca3782", "Person", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAECcXhow4HU4FdahJ3nBCrvsOOMtKBMdweNAAnfVZ+nLyNgfjT6+x71GSx4rCIMkg1A==", null, "07020464737", true, "aa6d51a4-789e-411d-8910-7afa01d82516", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b7e48780-4f88-4b7c-8ae4-89d7d9cc4104", "b28e2b12-8802-4f17-ae6a-40064ed260d1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a08f7bc-2add-444f-93d2-1b25c1c9d21f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce0ab11d-f63e-42f0-92dd-b4d4bd9bf637");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b7e48780-4f88-4b7c-8ae4-89d7d9cc4104", "b28e2b12-8802-4f17-ae6a-40064ed260d1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7e48780-4f88-4b7c-8ae4-89d7d9cc4104");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b28e2b12-8802-4f17-ae6a-40064ed260d1");

            migrationBuilder.DropColumn(
                name: "RoomStatus",
                table: "Rooms");

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
    }
}
