using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class PersonLastNameAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7bd8327-a436-40fa-8cc5-aa85e1b2d85e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd226eb4-f264-41eb-883b-69eb32263bc7");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bec33a22-d2ed-4877-b4cb-244aa17aea86", "a4955f7b-00a8-42e5-8f68-5b8c086d880b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bec33a22-d2ed-4877-b4cb-244aa17aea86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4955f7b-00a8-42e5-8f68-5b8c086d880b");

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "c0959c79-f8a7-4567-b0ba-756a33e8cd78", "c0959c79-f8a7-4567-b0ba-756a33e8cd78", "Usertype", "system administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "4dffd895-e89e-4302-8df9-ef6590c43c3d", "4dffd895-e89e-4302-8df9-ef6590c43c3d", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "6b33622a-cb70-424b-9d9b-a5ff0431b632", "6b33622a-cb70-424b-9d9b-a5ff0431b632", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0c2622fb-e3b0-4f04-b308-3c67334a71c3", 0, "c297dee6-01d7-42ed-b734-7977b11ad1d4", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEI5JfWk6q1FGMub1G7X8I8+XGVusvf915Ov+AKm4N6GtWkCV/OyR6MCGLN40JLnJGg==", null, "07020464737", true, "b8d38bea-1b0b-49cb-8f95-96f4f6e09003", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c0959c79-f8a7-4567-b0ba-756a33e8cd78", "0c2622fb-e3b0-4f04-b308-3c67334a71c3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dffd895-e89e-4302-8df9-ef6590c43c3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b33622a-cb70-424b-9d9b-a5ff0431b632");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0959c79-f8a7-4567-b0ba-756a33e8cd78", "0c2622fb-e3b0-4f04-b308-3c67334a71c3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0959c79-f8a7-4567-b0ba-756a33e8cd78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c2622fb-e3b0-4f04-b308-3c67334a71c3");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "bec33a22-d2ed-4877-b4cb-244aa17aea86", "bec33a22-d2ed-4877-b4cb-244aa17aea86", "Usertype", "system administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "a7bd8327-a436-40fa-8cc5-aa85e1b2d85e", "a7bd8327-a436-40fa-8cc5-aa85e1b2d85e", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "fd226eb4-f264-41eb-883b-69eb32263bc7", "fd226eb4-f264-41eb-883b-69eb32263bc7", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a4955f7b-00a8-42e5-8f68-5b8c086d880b", 0, "f72211ff-7a93-4c58-8a01-13d31909406f", "admin@mail.com", true, "Hassan", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAECfFXO1f0/sK/KyJk/GXVubbe5nGaEchgBAUsHbGl0GQcvEhVa3JAYByHh8RrhWJJw==", null, "07020464737", true, "163a3a9a-fee7-4c7a-b604-0f995f708ee7", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bec33a22-d2ed-4877-b4cb-244aa17aea86", "a4955f7b-00a8-42e5-8f68-5b8c086d880b" });
        }
    }
}
