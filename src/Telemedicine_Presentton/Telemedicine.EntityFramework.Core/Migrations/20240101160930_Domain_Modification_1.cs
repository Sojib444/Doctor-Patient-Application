using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telemedicine.EntityFramework.Core.Migrations
{
    /// <inheritdoc />
    public partial class Domain_Modification_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c5045f2-6cd7-45fb-83b2-098132a29ed1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "362eb03a-4cc4-4b14-ac41-38f4697824ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69efd30a-e518-4c74-88a5-2425684345be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcf318f8-38b1-4bbd-8715-986936d34867");

            migrationBuilder.DropColumn(
                name: "Patient_Name",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Doctor",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Patient",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Doctor", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Patient", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7197be99-5373-433b-87c6-dfae7937d07b", 0, "34bb67a7-d115-4455-8cdd-c3753de9c929", "User", 0, "dr2@gmail.com", false, false, null, "Dr. Johnson", null, null, "12345", 1, null, false, "668a6e3c-09cc-4b83-9975-3981fd910348", false, null },
                    { "9cb997eb-5526-4885-92db-6b7fc945380b", 0, "5eee2a65-932d-4eae-b33a-0e14c063cadd", "User", 1, "dr1@gmail.com", false, false, null, "Dr. Smith", null, null, "12345", 0, null, false, "94079488-58ca-41b4-8b29-ed3acbbd93da", false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7197be99-5373-433b-87c6-dfae7937d07b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cb997eb-5526-4885-92db-6b7fc945380b");

            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Patient",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Patient_Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1c5045f2-6cd7-45fb-83b2-098132a29ed1", 0, "673a2f16-e3f2-4fa9-aeb9-0a614454198b", "Doctor", "dr2@gmail.com", false, false, null, "Dr. Johnson", null, null, "12345", null, false, "96e4811f-07d8-4291-b4e9-8805a269a7c8", false, null },
                    { "362eb03a-4cc4-4b14-ac41-38f4697824ab", 0, "2348aa25-fe00-4c01-b91a-55dde0dc7e7b", "Doctor", "dr1@gmail.com", false, false, null, "Dr. Smith", null, null, "12345", null, false, "41b7b5dc-d2fb-4074-8e3e-48b571ebb1ea", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Patient_Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "69efd30a-e518-4c74-88a5-2425684345be", 0, "539eb82d-1a29-44dd-be01-3da1a585d27f", "Patient", "pr2@gmail.com", false, false, null, "Patient B", null, null, "12345", null, false, "d202da6a-b01d-4566-aae1-9152973e62a5", false, null },
                    { "bcf318f8-38b1-4bbd-8715-986936d34867", 0, "52e9552e-5325-4789-92b5-5c8d26f58511", "Patient", "pr1@gmail.com", false, false, null, "Patient A", null, null, "12345", null, false, "db297bba-6794-4cbe-9047-989620b187a3", false, null }
                });
        }
    }
}
