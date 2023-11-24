using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sof_feleves.Migrations
{
    public partial class post_title : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Services",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Posts",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "a4573903-6ba0-4be3-9a5b-ba4ebd8c5901");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "cea58b60-3e64-4b5b-91e5-f7c0ec278673");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "chiropractor_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ed7867c-5c16-4803-bf3d-895c6660636f", "AQAAAAEAACcQAAAAENHER8LS0UfQxqvPWu65QQevmCSpEE/uS104aiSuxApXJmx7BLrtSDtbibvNkayZ4A==", "989f7200-ca37-452d-960d-0985ce0630a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dance_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67ea5d47-d930-47d6-868a-cc4bdf4adb7f", "AQAAAAEAACcQAAAAEIoVM23sMKOoRFbZ0veZGr2Kof78uNVnhJZrxKWTX+lZA42qCdEwG8bLG6sckHo/2Q==", "14f26426-0259-4edd-a3f1-4459c810ebf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "nail_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82ce6375-d87c-4289-8eb1-2e8b2e0a1f5b", "AQAAAAEAACcQAAAAEIVsEs/zw3zXlWcTNihmkiA7B0Jj2JQ3LFq6KBm7o7Du//KrrBmAAgIFUPmRlNXxWA==", "9e4e1af7-331b-4ceb-ae28-04e9c19bcec0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "yoga_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d3cbe94-fb73-4190-ab5a-84c657e4c320", "AQAAAAEAACcQAAAAEOqyQ1XuheN+/94E7+znS2OrTmkK9NaYUBcQCKVXT+wHVEZVe/d55MDr+RuOebGhIg==", "2e0d331b-8ba9-4263-b911-33fe28d4647c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Services",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "24451565-5abd-465b-a221-72e3dd5d1818");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "000dcb17-441b-4114-bc86-f4cc8363bd94");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "chiropractor_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d042779a-3003-470b-9a11-610f145ea8d6", "AQAAAAEAACcQAAAAEHVJrIpCP6OyN6A3juSrHxP3N6X0Pd8asqK8ymyoYXFIOmdyk5ExT1W9OhJW6ATLeg==", "944a902d-4314-4e3b-b3f3-d928e97f76b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dance_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c328afe-e93b-4d06-a773-4d1531e96e99", "AQAAAAEAACcQAAAAEOdibugLjduVB+907Ir5+RyDl6VkIEbEzWrhUyGWiM7v2tRWFJcZNoyRhZDXLKUkSQ==", "a96dc764-8a16-418e-a588-e7f7bfe89fa1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "nail_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93542f87-748d-405c-8835-1af96fcd1b8c", "AQAAAAEAACcQAAAAEPMVdoO5KABef1Z2c5ZzM+lBR8TwGnM1lppyGTufDXXdG6i0uiQyZ1lsCUrmWIe3HA==", "ebadb899-ffb1-4e48-a1db-02c5ad0eb3b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "yoga_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08320484-01c5-4a3c-98f4-0604ba21d561", "AQAAAAEAACcQAAAAEFx8emvX0qxV4BMnRpcf5bCt46BXk/iqzDPsngqOAFXF7whhsoe8uvnJTZv25kNM/g==", "90cca1d5-9832-43b9-9079-06f2511b43f0" });
        }
    }
}
