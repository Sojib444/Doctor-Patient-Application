using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telemedicine.EntityFramework.Core.Migrations
{
    /// <inheritdoc />
    public partial class Domain_Modification_12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7197be99-5373-433b-87c6-dfae7937d07b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cb997eb-5526-4885-92db-6b7fc945380b");

            migrationBuilder.RenameColumn(
                name: "Patient",
                table: "AspNetUsers",
                newName: "AccoutType");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccoutType", "ConcurrencyStamp", "Discriminator", "Doctor", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2babb7ac-72d2-48d5-98e0-2eb17425da75", 0, 2, "a2e53035-6c78-4e2b-83c5-11b7a95f5476", "User", 0, "dr2@gmail.com", false, false, null, "Dr. Johnson", null, null, "12345", null, false, "78858f49-0a9d-4352-82a3-c62de95ffbf0", false, null },
                    { "2ca76869-ad7b-4cad-a150-66d41ee3f360", 0, 1, "303946da-d340-43ae-9caf-1aa3097f6d67", "User", 0, "dr1@gmail.com", false, false, null, "Dr. Smith", null, null, "12345", null, false, "3a691bae-b7a9-4f29-9dbc-ba291b4a350e", false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2babb7ac-72d2-48d5-98e0-2eb17425da75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ca76869-ad7b-4cad-a150-66d41ee3f360");

            migrationBuilder.RenameColumn(
                name: "AccoutType",
                table: "AspNetUsers",
                newName: "Patient");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Doctor", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Patient", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7197be99-5373-433b-87c6-dfae7937d07b", 0, "34bb67a7-d115-4455-8cdd-c3753de9c929", "User", 0, "dr2@gmail.com", false, false, null, "Dr. Johnson", null, null, "12345", 1, null, false, "668a6e3c-09cc-4b83-9975-3981fd910348", false, null },
                    { "9cb997eb-5526-4885-92db-6b7fc945380b", 0, "5eee2a65-932d-4eae-b33a-0e14c063cadd", "User", 1, "dr1@gmail.com", false, false, null, "Dr. Smith", null, null, "12345", 0, null, false, "94079488-58ca-41b4-8b29-ed3acbbd93da", false, null }
                });
        }
    }
}
