using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class RoomStatusToStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "RoomStatus",
                table: "Rooms",
                newName: "Status");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "2402ff3e-7ac9-4036-abab-6602276a8860", "2402ff3e-7ac9-4036-abab-6602276a8860", "Usertype", "system_administrator", "SYSTEM_ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "7da6e1fa-8ec5-4eba-a0c8-3d889605412a", "7da6e1fa-8ec5-4eba-a0c8-3d889605412a", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "d25c62f4-dbf1-4440-8ec0-4de9dbc1f507", "d25c62f4-dbf1-4440-8ec0-4de9dbc1f507", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c8ccf8a7-fc9d-4c73-8c73-0b921a49fb0b", 0, "1f0b617b-db1d-49df-936e-753bd81fed20", "Person", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEGJlP/F/5cxb9oiFgz5Msby6Uef1HeaLWioA9CdkiE8dgLYrYJMjnEsrDXYWOSgVww==", null, "07020464737", true, "b631d552-22e0-41b5-abb6-9845e0588a9e", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2402ff3e-7ac9-4036-abab-6602276a8860", "c8ccf8a7-fc9d-4c73-8c73-0b921a49fb0b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7da6e1fa-8ec5-4eba-a0c8-3d889605412a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d25c62f4-dbf1-4440-8ec0-4de9dbc1f507");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2402ff3e-7ac9-4036-abab-6602276a8860", "c8ccf8a7-fc9d-4c73-8c73-0b921a49fb0b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2402ff3e-7ac9-4036-abab-6602276a8860");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8ccf8a7-fc9d-4c73-8c73-0b921a49fb0b");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Rooms",
                newName: "RoomStatus");

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
    }
}
