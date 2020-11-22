using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class RoomsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "RoomCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CostPerNight = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FloorNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomNumber = table.Column<string>(type: "TEXT", nullable: true),
                    RoomCategoryId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomCategories_RoomCategoryId",
                        column: x => x.RoomCategoryId,
                        principalTable: "RoomCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "a3914aba-a383-4a14-b549-ac3cae6f5fa9", "a3914aba-a383-4a14-b549-ac3cae6f5fa9", "Usertype", "system administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "4df84341-1dfa-4030-a233-3d3ec55ab887", "4df84341-1dfa-4030-a233-3d3ec55ab887", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "c3ac3a60-feb8-41dd-ad5b-f9dd5b1c393f", "c3ac3a60-feb8-41dd-ad5b-f9dd5b1c393f", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c456b4fe-5528-454d-baa5-e207a2a4fe34", 0, "6732d250-3772-4d82-b1e4-fb1d3e84e390", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEESsOkQNOo/SuxoIIFfj9baGKpC8CCgc+py3obk5Yb502mvibO79yn0wwi/jLdsKfA==", null, "07020464737", true, "25dbf63e-e535-4fd5-b179-99cbaa79a6f7", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a3914aba-a383-4a14-b549-ac3cae6f5fa9", "c456b4fe-5528-454d-baa5-e207a2a4fe34" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email_UserName",
                table: "AspNetUsers",
                columns: new[] { "Email", "UserName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomCategories_Name",
                table: "RoomCategories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomCategoryId",
                table: "Rooms",
                column: "RoomCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomNumber",
                table: "Rooms",
                column: "RoomNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomCategories");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Email_UserName",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4df84341-1dfa-4030-a233-3d3ec55ab887");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3ac3a60-feb8-41dd-ad5b-f9dd5b1c393f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a3914aba-a383-4a14-b549-ac3cae6f5fa9", "c456b4fe-5528-454d-baa5-e207a2a4fe34" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3914aba-a383-4a14-b549-ac3cae6f5fa9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c456b4fe-5528-454d-baa5-e207a2a4fe34");

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
    }
}
