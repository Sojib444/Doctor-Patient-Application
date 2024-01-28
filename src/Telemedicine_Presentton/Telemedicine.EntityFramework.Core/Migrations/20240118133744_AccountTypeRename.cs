using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telemedicine.EntityFramework.Core.Migrations
{
    /// <inheritdoc />
    public partial class AccountTypeRename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52eac1ae-95e0-43f0-ad5c-40c6dcc9c7f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62dcdc6f-9a15-487b-8706-baf212f2c136");

            migrationBuilder.RenameColumn(
                name: "AccoutType",
                table: "AspNetUsers",
                newName: "AccountType");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "ConcurrencyStamp", "Discriminator", "Doctor", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "231dae3b-f3d5-4765-afa8-b2aec706b10a", 0, 1, "af651e1c-69c1-4f0a-bdd6-c84db1bfab24", "User", 0, "dr1@gmail.com", false, false, null, "Dr. Smith", null, null, "12345", null, false, "c31310be-120b-4d31-b2fb-61ab93522108", false, null },
                    { "764be0ce-f160-4b91-89a7-d38dc6aeca53", 0, 2, "be7b7eec-8957-478a-886f-037cc9734b81", "User", 0, "dr2@gmail.com", false, false, null, "Dr. Johnson", null, null, "12345", null, false, "27e1e0e2-7041-4dab-82cd-2b4adf5af1e4", false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "231dae3b-f3d5-4765-afa8-b2aec706b10a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "764be0ce-f160-4b91-89a7-d38dc6aeca53");

            migrationBuilder.RenameColumn(
                name: "AccountType",
                table: "AspNetUsers",
                newName: "AccoutType");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccoutType", "ConcurrencyStamp", "Discriminator", "Doctor", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "52eac1ae-95e0-43f0-ad5c-40c6dcc9c7f6", 0, 2, "b7a62833-1782-406b-a628-94c189729931", "User", 0, "dr2@gmail.com", false, false, null, "Dr. Johnson", null, null, "12345", null, false, "283ae5e2-0cff-4b78-abc2-e94646924639", false, null },
                    { "62dcdc6f-9a15-487b-8706-baf212f2c136", 0, 1, "1a3b895e-5111-4acb-acbd-09a781b76018", "User", 0, "dr1@gmail.com", false, false, null, "Dr. Smith", null, null, "12345", null, false, "979b45f8-e8b8-4255-bc50-acabf1ce4c05", false, null }
                });
        }
    }
}
