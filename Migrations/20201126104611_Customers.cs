using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class Customers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11d95d65-ac86-4804-85cc-42bb203b47de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51fec5fa-522c-4ea0-b1de-9ba67511e30d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bdb7f86e-94cd-42c4-8a75-647324db5fac", "edc1bd1d-1262-458e-92a8-da8cfe81217b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdb7f86e-94cd-42c4-8a75-647324db5fac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc1bd1d-1262-458e-92a8-da8cfe81217b");

            migrationBuilder.RenameColumn(
                name: "PassportPhoto",
                table: "AspNetUsers",
                newName: "MeansOfIdentification");

            migrationBuilder.RenameColumn(
                name: "PassportNumber",
                table: "AspNetUsers",
                newName: "IdentificationNumber");

            migrationBuilder.AddColumn<int>(
                name: "MeansOfIdentificationType",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "MeansOfIdentificationType",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "MeansOfIdentification",
                table: "AspNetUsers",
                newName: "PassportPhoto");

            migrationBuilder.RenameColumn(
                name: "IdentificationNumber",
                table: "AspNetUsers",
                newName: "PassportNumber");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "bdb7f86e-94cd-42c4-8a75-647324db5fac", "bdb7f86e-94cd-42c4-8a75-647324db5fac", "Usertype", "system administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "51fec5fa-522c-4ea0-b1de-9ba67511e30d", "51fec5fa-522c-4ea0-b1de-9ba67511e30d", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "11d95d65-ac86-4804-85cc-42bb203b47de", "11d95d65-ac86-4804-85cc-42bb203b47de", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "edc1bd1d-1262-458e-92a8-da8cfe81217b", 0, "41fee47b-3c4f-404a-bebe-dc0cdd0aa98d", "Person", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEGUz5JI813ONoBic6aC7MoQlA5vy+hNXPZRbiTTpxn+31Qho0w2m1zOlj+Gb78NjNw==", null, "07020464737", true, "8eada88c-bf1e-41fd-824a-bc622e20f431", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bdb7f86e-94cd-42c4-8a75-647324db5fac", "edc1bd1d-1262-458e-92a8-da8cfe81217b" });
        }
    }
}
