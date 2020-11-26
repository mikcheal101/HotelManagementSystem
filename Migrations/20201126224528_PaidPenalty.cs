using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Migrations
{
    public partial class PaidPenalty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bbca874-0d71-45fb-bcc1-81dc7cc465e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d463df8-2772-4ff6-b3d6-9db889c77975");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e618b0b-8cd4-4d24-b814-1d0cf50c55be", "aa5a3778-46a7-49e2-b033-beed3c09e494" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e618b0b-8cd4-4d24-b814-1d0cf50c55be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5a3778-46a7-49e2-b033-beed3c09e494");

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<string>(type: "TEXT", nullable: true),
                    RoomId = table.Column<string>(type: "TEXT", nullable: true),
                    CheckInTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CheckOutTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpectedCheckOutTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AttendantId = table.Column<string>(type: "TEXT", nullable: true),
                    PaidPenalty = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_AttendantId",
                        column: x => x.AttendantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "f0ac7fd8-3843-4cee-90e7-0240d4620924", "f0ac7fd8-3843-4cee-90e7-0240d4620924", "Usertype", "system_administrator", "SYSTEM_ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "5769fc2a-b18a-45b8-ae17-7cf2ba01a80b", "5769fc2a-b18a-45b8-ae17-7cf2ba01a80b", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "bf50efe5-3940-48ed-b187-23cea92dcf32", "bf50efe5-3940-48ed-b187-23cea92dcf32", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "26c61922-c53f-4b66-9ddb-55752bdc7a3b", 0, "368cf53f-0e40-4a20-b40e-70e214739814", "Person", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEBVcsr5rCYllU0NkIKpBsYUZk1IUrDULb5gy3cXMHs3aiZxjUzdamnNY5M4jLKPjIQ==", null, "07020464737", true, "fdcb70e1-0fc5-4892-83fd-66156ff124c4", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f0ac7fd8-3843-4cee-90e7-0240d4620924", "26c61922-c53f-4b66-9ddb-55752bdc7a3b" });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_AttendantId",
                table: "Bookings",
                column: "AttendantId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomId",
                table: "Bookings",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5769fc2a-b18a-45b8-ae17-7cf2ba01a80b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf50efe5-3940-48ed-b187-23cea92dcf32");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f0ac7fd8-3843-4cee-90e7-0240d4620924", "26c61922-c53f-4b66-9ddb-55752bdc7a3b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0ac7fd8-3843-4cee-90e7-0240d4620924");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26c61922-c53f-4b66-9ddb-55752bdc7a3b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "9e618b0b-8cd4-4d24-b814-1d0cf50c55be", "9e618b0b-8cd4-4d24-b814-1d0cf50c55be", "Usertype", "system_administrator", "SYSTEM_ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "8d463df8-2772-4ff6-b3d6-9db889c77975", "8d463df8-2772-4ff6-b3d6-9db889c77975", "Usertype", "employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "5bbca874-0d71-45fb-bcc1-81dc7cc465e0", "5bbca874-0d71-45fb-bcc1-81dc7cc465e0", "Usertype", "customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonTypeId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aa5a3778-46a7-49e2-b033-beed3c09e494", 0, "6e3e7c4b-6b49-4ea3-ba87-bb2138d63108", "Person", "admin@mail.com", true, "Hassan", "Dalatu", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEMjcjWr77tE+vbb3becCFxWbJLh5xQo3pTzLJKPNg2eBBzoZTgLGlneAGw075Jx2RQ==", null, "07020464737", true, "e9ef95a4-2718-422b-b3f6-e312fb0b2257", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9e618b0b-8cd4-4d24-b814-1d0cf50c55be", "aa5a3778-46a7-49e2-b033-beed3c09e494" });
        }
    }
}
