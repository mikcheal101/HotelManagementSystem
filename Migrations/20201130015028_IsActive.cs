using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class IsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Bookings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "5e0104d7-dd29-441f-9626-dc60b886966e", "5e0104d7-dd29-441f-9626-dc60b886966e", "Usertype", "system_administrator", "SYSTEM_ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "d2ca0e99-04fb-416c-9ef0-becbf7b2a1e5", "d2ca0e99-04fb-416c-9ef0-becbf7b2a1e5", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "51ec9058-a251-458d-9cd0-3430fd308061", "51ec9058-a251-458d-9cd0-3430fd308061", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c8d80fe2-701f-4b50-8ea6-376837cd36a7", 0, "c202ae4f-8be3-4777-8859-974cafef4060", "Person", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEJ78Qfd9cJGIQ8BDlnVCITMn5DuMr1Th9JIg0ZVpvadHxXkbcQnVXm1zINZhhET7AQ==", null, "07020464737", true, "998702f9-bcb1-4d67-a909-f158865dc4fc", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5e0104d7-dd29-441f-9626-dc60b886966e", "c8d80fe2-701f-4b50-8ea6-376837cd36a7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51ec9058-a251-458d-9cd0-3430fd308061");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2ca0e99-04fb-416c-9ef0-becbf7b2a1e5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5e0104d7-dd29-441f-9626-dc60b886966e", "c8d80fe2-701f-4b50-8ea6-376837cd36a7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e0104d7-dd29-441f-9626-dc60b886966e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8d80fe2-701f-4b50-8ea6-376837cd36a7");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Bookings");

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
    }
}
