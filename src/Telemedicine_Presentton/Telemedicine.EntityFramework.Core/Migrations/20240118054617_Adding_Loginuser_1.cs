using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telemedicine.EntityFramework.Core.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Loginuser_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ef5b2b9-9cad-4d21-b860-1073781c1e7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c2e73c5-4a06-4c16-8ed2-fe3090cab7bc");

            migrationBuilder.CreateTable(
                name: "LoginUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccoutType", "ConcurrencyStamp", "Discriminator", "Doctor", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "52eac1ae-95e0-43f0-ad5c-40c6dcc9c7f6", 0, 2, "b7a62833-1782-406b-a628-94c189729931", "User", 0, "dr2@gmail.com", false, false, null, "Dr. Johnson", null, null, "12345", null, false, "283ae5e2-0cff-4b78-abc2-e94646924639", false, null },
                    { "62dcdc6f-9a15-487b-8706-baf212f2c136", 0, 1, "1a3b895e-5111-4acb-acbd-09a781b76018", "User", 0, "dr1@gmail.com", false, false, null, "Dr. Smith", null, null, "12345", null, false, "979b45f8-e8b8-4255-bc50-acabf1ce4c05", false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52eac1ae-95e0-43f0-ad5c-40c6dcc9c7f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62dcdc6f-9a15-487b-8706-baf212f2c136");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccoutType", "ConcurrencyStamp", "Discriminator", "Doctor", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5ef5b2b9-9cad-4d21-b860-1073781c1e7f", 0, 2, "a9eebdde-db2a-4d2e-baba-8af2eb4f509a", "User", 0, "dr2@gmail.com", false, false, null, "Dr. Johnson", null, null, "12345", null, false, "9812c850-4376-4399-a6a1-fffbdc99e018", false, null },
                    { "7c2e73c5-4a06-4c16-8ed2-fe3090cab7bc", 0, 1, "1995940f-5edd-4e4f-bc79-b10dceef4e36", "User", 0, "dr1@gmail.com", false, false, null, "Dr. Smith", null, null, "12345", null, false, "55b19e4d-8350-4f46-b024-d5e6e48f5f84", false, null }
                });
        }
    }
}
