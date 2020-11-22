using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class DbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomCategories_RoomCategoryId",
                table: "Rooms");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "080db2a2-6000-45f7-a270-5db2aa176b89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "418e1890-b737-4d33-aa74-9eb5bf64de24");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1ca89ca5-6fe2-4b50-b632-bbbebdf682db", "6a32a94b-2d96-4392-ac33-5604c83f98b4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ca89ca5-6fe2-4b50-b632-bbbebdf682db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a32a94b-2d96-4392-ac33-5604c83f98b4");

            migrationBuilder.AlterColumn<string>(
                name: "RoomCategoryId",
                table: "Rooms",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomCategories_RoomCategoryId",
                table: "Rooms",
                column: "RoomCategoryId",
                principalTable: "RoomCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomCategories_RoomCategoryId",
                table: "Rooms");

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

            migrationBuilder.AlterColumn<string>(
                name: "RoomCategoryId",
                table: "Rooms",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "1ca89ca5-6fe2-4b50-b632-bbbebdf682db", "1ca89ca5-6fe2-4b50-b632-bbbebdf682db", "Usertype", "system administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "418e1890-b737-4d33-aa74-9eb5bf64de24", "418e1890-b737-4d33-aa74-9eb5bf64de24", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "080db2a2-6000-45f7-a270-5db2aa176b89", "080db2a2-6000-45f7-a270-5db2aa176b89", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6a32a94b-2d96-4392-ac33-5604c83f98b4", 0, "33d2d3c3-0c1a-4c4b-aeb7-0ba2651826ab", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAELOQBQgssOcXKqeEFW1KLrouAUJAbzfINa5uN8VTQRZcDhQ0hGEbrE9sMuUtJaJhYQ==", null, "07020464737", true, "d3178f2e-24e4-470a-bc34-7c276690d930", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1ca89ca5-6fe2-4b50-b632-bbbebdf682db", "6a32a94b-2d96-4392-ac33-5604c83f98b4" });

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomCategories_RoomCategoryId",
                table: "Rooms",
                column: "RoomCategoryId",
                principalTable: "RoomCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
