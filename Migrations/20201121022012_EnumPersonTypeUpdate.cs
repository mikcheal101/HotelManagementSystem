using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class EnumPersonTypeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81d75c32-b89a-48bc-9c02-deebba2ecc45");

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "0054c16c-ad1d-442e-94a4-ff3319ba3ae1", 0, "de5dd8ae-e40e-41f1-aaa5-567f5ad8a451", "admin@mail.com", true, "Hassan", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEP8F17f6kV504WmJJqjDPf6cuiEGvJvugSZ19YRGaXRBAjDS8bQZp4F7LIwMPkK/ZQ==", "07020464737", true, "55c98c0c-7b66-4f46-8662-8686dccb16e1", false, "admin@mail.com", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0054c16c-ad1d-442e-94a4-ff3319ba3ae1");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "81d75c32-b89a-48bc-9c02-deebba2ecc45", 0, "209a0e11-5a3c-47c8-85d2-c43a38246200", "admin@mail.com", true, "Hassan", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEGzcBUoZqp5F1y99vxWAuzYRpngnVgWlvqo/7jP3dGl2+1FhmrQMI0/hfARgpOdHbg==", "07020464737", true, "f6803bf2-d377-4c69-8b2a-a4609cb2ea4c", false, "admin@mail.com" });
        }
    }
}
