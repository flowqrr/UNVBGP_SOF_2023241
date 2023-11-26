using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sof_feleves.Migrations
{
    public partial class location : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Services",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "6b96fdf3-72d5-42bf-998f-3183e9d0f0d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d137f1d3-bd11-4e13-a162-e0a2235eeacb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "chiropractor_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b20dfab-6141-478c-b80f-adb0d6e4156f", "AQAAAAEAACcQAAAAECmTgg38qlzvUtK91Lq8N7XK0ObwFMB0LfFUM7G5v762ZXFmQgxAYYTj6qpuvwJaIQ==", "24a85fb3-80eb-4fdb-b739-33162a37ffac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dance_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7704cfe8-050e-477b-b275-7731b160d073", "AQAAAAEAACcQAAAAEGbOtHofS9DogjoDpZ6V6dlb2Wl6vEFEaEDgrW+RcyRgLXJbVPpdI/aKgdmreGCC+w==", "ba2cfa75-5d5b-4cd1-8252-f164f16ed908" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "nail_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69024b12-39e0-4d5a-ab12-7855b377ea10", "AQAAAAEAACcQAAAAEFzdsFDqGX3zBPlqxbE8G58bzksJUtFgeE75gKQDiEzWk0ku3ni64UIFdTANQigrpw==", "955b52bb-46cc-4013-a57d-4b52a05dedb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "yoga_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4be014c-7710-4d55-b1ba-61a8ae1e41ed", "AQAAAAEAACcQAAAAEN0xXEZG3rhLPCOayV/4j2l/x4sIQOvPTpkw2U4MBT4/o0vTGXFHPDHG2neOHMBxzg==", "bca54161-20e8-487a-a01a-e3a1266437fb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Services");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "daa5847f-f29e-46ae-845c-5ed5ebf1abbc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ad0d4d37-ef6f-4f93-a550-a2fb7f167eca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "chiropractor_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b52674f-5f4e-408c-99f4-94ea6c894ad4", "AQAAAAEAACcQAAAAEFWY/XwzSEKH6xcaA1s+Wr04L/otLNi+g9+a6fXLPcQuAFXlKhtb62tAMQNhMLAg7g==", "d521b99a-5cd2-4504-8227-468665fa953e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dance_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d9c6eab-c8c6-4117-b6bd-c1a4274bb4d9", "AQAAAAEAACcQAAAAEFXXjp4tgOimRe2DENP/wtbYy23TNnKhkoVBwUycyKo9Fq0W9q80eAcmFl7lNbF7lQ==", "93c022f2-094a-4b81-bb80-d4b25b3337cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "nail_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba71e1a4-569b-42ff-abf2-bfa3e4bcfe84", "AQAAAAEAACcQAAAAENCQ146AzfV3E3L4k9QwbWoWIFLDXOSvurAPHA/O3gmV5/2UkM+ZD66GAAIuX+ANOQ==", "8f416fd6-c884-408b-bbe7-d1fd745d62fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "yoga_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30456317-abec-47ba-bf1b-668abe72b709", "AQAAAAEAACcQAAAAEFP4Q7LqTK4VQf4/WXGhVyMeQaiMGZCFPvkaEPB1PLqN6iOlhPefsZtvVF+U561oVg==", "073fb035-3669-4841-a928-48971cd799b1" });
        }
    }
}
