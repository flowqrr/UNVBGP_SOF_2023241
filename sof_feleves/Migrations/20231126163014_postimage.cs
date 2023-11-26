using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sof_feleves.Migrations
{
    public partial class postimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "ImageContentType",
                table: "Posts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Posts",
                type: "bytea",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageContentType",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
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
    }
}
