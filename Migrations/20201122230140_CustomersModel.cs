using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class CustomersModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a949a62-b042-4777-b125-207d7664f355");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdee14fa-3964-4e27-a8b3-32d6372892ac");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a43b8ebb-e9e6-404c-9189-1a57fc08701a", "0b477c47-5957-4d06-be16-3b861990c4ac" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a43b8ebb-e9e6-404c-9189-1a57fc08701a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b477c47-5957-4d06-be16-3b861990c4ac");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PassportNumber",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportPhoto",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "bd930e65-6da4-40ff-9513-6777045fb445", "bd930e65-6da4-40ff-9513-6777045fb445", "Usertype", "system administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "3aa40dc6-9a5d-4c63-a1d9-7ee1801907dd", "3aa40dc6-9a5d-4c63-a1d9-7ee1801907dd", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "f7073b03-962c-4399-a3d6-810116cb8760", "f7073b03-962c-4399-a3d6-810116cb8760", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "980b7fe5-fe97-4bac-bc95-ea1da8ed0a08", 0, "4d8eb12f-bfec-4ee2-929c-c30e36bf45a1", "Person", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEN+IqvBRx1HQ6hNS+hMgGrEdj5svdazhtG+nAgLsJIwDfQjSPT8wBIuTbMJ3MLrx1w==", null, "07020464737", true, "688dae8c-d066-44eb-b483-d9f90fac095f", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd930e65-6da4-40ff-9513-6777045fb445", "980b7fe5-fe97-4bac-bc95-ea1da8ed0a08" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aa40dc6-9a5d-4c63-a1d9-7ee1801907dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7073b03-962c-4399-a3d6-810116cb8760");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd930e65-6da4-40ff-9513-6777045fb445", "980b7fe5-fe97-4bac-bc95-ea1da8ed0a08" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd930e65-6da4-40ff-9513-6777045fb445");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "980b7fe5-fe97-4bac-bc95-ea1da8ed0a08");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PassportNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PassportPhoto",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "a43b8ebb-e9e6-404c-9189-1a57fc08701a", "a43b8ebb-e9e6-404c-9189-1a57fc08701a", "Usertype", "system administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "1a949a62-b042-4777-b125-207d7664f355", "1a949a62-b042-4777-b125-207d7664f355", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "bdee14fa-3964-4e27-a8b3-32d6372892ac", "bdee14fa-3964-4e27-a8b3-32d6372892ac", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0b477c47-5957-4d06-be16-3b861990c4ac", 0, "be22a90e-8790-4f3b-b745-d7efb3081983", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEGx1kbc8dEchCEvDBksBNJ7rKTxFdb5hSW5P21Smc3FesYPTOMkMKfpxlmTjDjAVlg==", null, "07020464737", true, "8c7a55b9-1e99-4224-b220-edb5f25d4038", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a43b8ebb-e9e6-404c-9189-1a57fc08701a", "0b477c47-5957-4d06-be16-3b861990c4ac" });
        }
    }
}
