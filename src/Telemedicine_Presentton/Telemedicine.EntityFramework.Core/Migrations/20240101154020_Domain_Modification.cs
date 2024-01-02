using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telemedicine.EntityFramework.Core.Migrations
{
    /// <inheritdoc />
    public partial class Domain_Modification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "065ebb40-52ff-4f26-a2c3-7aff9f462aa4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61b50438-a9f1-41fb-96cd-4f8658146503");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a75d4c88-0011-480f-a4d0-803e62c97f5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c793119c-2d3e-45c6-b308-9e7778d1e35c");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DesingNation",
                table: "AspNetUsers");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DesingNation",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DesingNation", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "065ebb40-52ff-4f26-a2c3-7aff9f462aa4", 0, "521743ef-454b-406c-bb89-1b946c866deb", "MBBS", "Doctor", "dr1@gmail.com", false, false, null, "Dr. Smith", null, null, "12345", null, false, "b67c733a-5ba6-43e4-87de-0337b7de5bd5", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Patient_Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "61b50438-a9f1-41fb-96cd-4f8658146503", 0, "Pabna", "683a5761-c17e-412b-b7c2-f732af166c2e", "Patient", "pr1@gmail.com", false, false, null, "Patient A", null, null, "12345", null, false, "e0ca4357-a060-48c3-b7d6-3bb9685388f4", false, null },
                    { "a75d4c88-0011-480f-a4d0-803e62c97f5d", 0, "Kushtia", "350cdfb2-6d2c-497a-b80b-29e541c31457", "Patient", "pr2@gmail.com", false, false, null, "Patient B", null, null, "12345", null, false, "cd651a05-241c-47f6-9137-ed38346cdb9c", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DesingNation", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c793119c-2d3e-45c6-b308-9e7778d1e35c", 0, "3a3e2875-1064-4182-948d-8d0057ebf390", "MBBS", "Doctor", "dr2@gmail.com", false, false, null, "Dr. Johnson", null, null, "12345", null, false, "eefc1403-bd21-4e55-84fa-0f580f0c8263", false, null });
        }
    }
}
