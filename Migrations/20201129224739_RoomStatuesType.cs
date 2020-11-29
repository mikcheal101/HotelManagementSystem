using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class RoomStatuesType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "RoomStatus",
                table: "Rooms",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "b7711aa2-ac9e-466b-92a0-7263c5958317", "b7711aa2-ac9e-466b-92a0-7263c5958317", "Usertype", "system_administrator", "SYSTEM_ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "2d090995-0515-4ec3-827c-8ad46e8d1789", "2d090995-0515-4ec3-827c-8ad46e8d1789", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "eac6cbbc-e57a-45bc-9865-3099ac0fd4ee", "eac6cbbc-e57a-45bc-9865-3099ac0fd4ee", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2c14027b-4ba4-4c66-bd82-e0114e65d3cf", 0, "f3bc139b-6fcd-414f-9d45-20988ec6928c", "Person", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAECj7Hivn8GxMEEhdTF3D9AFM8RBCkIornN04A2I+HxEIHZDVZgt6F3T5//d0eA+J7w==", null, "07020464737", true, "70a89844-9481-4195-9e98-1c3f3458db24", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b7711aa2-ac9e-466b-92a0-7263c5958317", "2c14027b-4ba4-4c66-bd82-e0114e65d3cf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d090995-0515-4ec3-827c-8ad46e8d1789");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eac6cbbc-e57a-45bc-9865-3099ac0fd4ee");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b7711aa2-ac9e-466b-92a0-7263c5958317", "2c14027b-4ba4-4c66-bd82-e0114e65d3cf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7711aa2-ac9e-466b-92a0-7263c5958317");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c14027b-4ba4-4c66-bd82-e0114e65d3cf");

            migrationBuilder.AlterColumn<string>(
                name: "RoomStatus",
                table: "Rooms",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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
    }
}
