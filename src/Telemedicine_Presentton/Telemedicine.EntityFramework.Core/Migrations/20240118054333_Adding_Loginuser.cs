using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telemedicine.EntityFramework.Core.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Loginuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46adb200-2fdb-4ffc-9e9c-f6c099ec3539");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5978f30e-1b5c-493a-b1f2-25d0be7bae67");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccoutType", "ConcurrencyStamp", "Discriminator", "Doctor", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5ef5b2b9-9cad-4d21-b860-1073781c1e7f", 0, 2, "a9eebdde-db2a-4d2e-baba-8af2eb4f509a", "User", 0, "dr2@gmail.com", false, false, null, "Dr. Johnson", null, null, "12345", null, false, "9812c850-4376-4399-a6a1-fffbdc99e018", false, null },
                    { "7c2e73c5-4a06-4c16-8ed2-fe3090cab7bc", 0, 1, "1995940f-5edd-4e4f-bc79-b10dceef4e36", "User", 0, "dr1@gmail.com", false, false, null, "Dr. Smith", null, null, "12345", null, false, "55b19e4d-8350-4f46-b024-d5e6e48f5f84", false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ef5b2b9-9cad-4d21-b860-1073781c1e7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c2e73c5-4a06-4c16-8ed2-fe3090cab7bc");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccoutType", "ConcurrencyStamp", "Discriminator", "Doctor", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "46adb200-2fdb-4ffc-9e9c-f6c099ec3539", 0, 2, "e0ec01f2-9076-4273-b06c-505beede3e75", "User", 0, "dr2@gmail.com", false, false, null, "Dr. Johnson", null, null, "12345", null, false, "6d044edf-d9d0-4e70-bee6-ba76d1781258", false, null },
                    { "5978f30e-1b5c-493a-b1f2-25d0be7bae67", 0, 1, "72bea670-1dd9-4994-af9b-f696b7f1ee2f", "User", 0, "dr1@gmail.com", false, false, null, "Dr. Smith", null, null, "12345", null, false, "276fcf2c-0b34-42f6-a042-fa45688481c0", false, null }
                });
        }
    }
}
