using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telemedicine.EntityFramework.Core.Migrations
{
    /// <inheritdoc />
    public partial class Domain_Modification_13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2babb7ac-72d2-48d5-98e0-2eb17425da75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ca76869-ad7b-4cad-a150-66d41ee3f360");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccoutType", "ConcurrencyStamp", "Discriminator", "Doctor", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "46adb200-2fdb-4ffc-9e9c-f6c099ec3539", 0, 2, "e0ec01f2-9076-4273-b06c-505beede3e75", "User", 0, "dr2@gmail.com", false, false, null, "Dr. Johnson", null, null, "12345", null, false, "6d044edf-d9d0-4e70-bee6-ba76d1781258", false, null },
                    { "5978f30e-1b5c-493a-b1f2-25d0be7bae67", 0, 1, "72bea670-1dd9-4994-af9b-f696b7f1ee2f", "User", 0, "dr1@gmail.com", false, false, null, "Dr. Smith", null, null, "12345", null, false, "276fcf2c-0b34-42f6-a042-fa45688481c0", false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "2babb7ac-72d2-48d5-98e0-2eb17425da75", 0, 2, "a2e53035-6c78-4e2b-83c5-11b7a95f5476", "User", 0, "dr2@gmail.com", false, false, null, "Dr. Johnson", null, null, "12345", null, false, "78858f49-0a9d-4352-82a3-c62de95ffbf0", false, null },
                    { "2ca76869-ad7b-4cad-a150-66d41ee3f360", 0, 1, "303946da-d340-43ae-9caf-1aa3097f6d67", "User", 0, "dr1@gmail.com", false, false, null, "Dr. Smith", null, null, "12345", null, false, "3a691bae-b7a9-4f29-9dbc-ba291b4a350e", false, null }
                });
        }
    }
}
