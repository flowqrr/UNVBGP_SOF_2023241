using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sof_feleves.Migrations
{
    public partial class profilepic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePicContentType",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicData",
                table: "AspNetUsers",
                type: "bytea",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "36b0df13-3caa-42ef-a482-3a266da2efa8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a5cba591-10a3-4beb-90a5-00a365df3628");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "chiropractor_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f551ebfd-3b0c-43df-8a72-943c36927d1c", "AQAAAAEAACcQAAAAEKj9rv2YVZLvdpEo4t6DjHHRrhbqqyC0dGw1Yv1pPebKAActinfcj6FddmYRQa4PHg==", "5c845e61-4542-4c77-a0aa-ff296b38350c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dance_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94cdd72b-e30c-4467-aab5-b18bb14898f6", "AQAAAAEAACcQAAAAEFh3C78k7UuCNxucTuzAeMw/hX5FIBhtSznVTSbbPI/3DwEATGSATDDX4SGTn/ALyQ==", "61648d0f-bdda-4fa6-9b0b-615eed2ddcb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "nail_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "065648d5-ecde-458a-937e-2bd884022118", "AQAAAAEAACcQAAAAEPiRetpdTQa0ay79pAR2/losCO+YUOjaq6S3AT41Nkn6XF+WAY8p/dnR9UlkQ8TMUQ==", "333932ff-2c66-4df2-a826-79d5f2829fc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "yoga_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c635e80d-72fb-4b4e-826c-221845931e41", "AQAAAAEAACcQAAAAEJ7vYtB8df4k6UfNqYdTPPY7u0sOZYBR4FWT47O3iyLm2h8ZdLke3nCc9mP1oO7b+Q==", "0c35d498-c58e-4891-9acd-befc630a16ba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicContentType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePicData",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "64f0b2bc-4d79-4aaf-bf91-8a5adccbfcec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a7c9a7c5-dec1-4c77-b81e-dd690be9953b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "chiropractor_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "642cb94d-da4f-4a09-8ed2-ca5d28b50d0d", "AQAAAAEAACcQAAAAEPOGgLfVKHn78Lt51oGx/VNyP+RIcn0h3KwH5nYh6Bj6ksT79Zk9I0zxhaH5TBsiXA==", "f108d814-c3d4-46d2-aa60-c2f59598d607" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dance_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a0ddd0e-4c10-4575-8127-b002d3c37322", "AQAAAAEAACcQAAAAEGQldynZ0yA1wxG+0iFn0PhgXIMiJH3kWUupp03TtffWygrZHskv+y8wzM/Sc/wJAg==", "b369ffaa-1131-4e07-8dc7-24ab38b48299" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "nail_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71d65d3f-145f-43c0-9848-5e196744cd4d", "AQAAAAEAACcQAAAAEEA35Ytag8/8H9AwpJjldWvSGc26weSyWS5Hg4RCBrHfgnEitvYR7zqDVIi17uD+Gg==", "5d3aba63-cfd9-4bb6-8318-a579f48935b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "yoga_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "321f8e44-7ea4-40b2-ace9-c05ae3f41406", "AQAAAAEAACcQAAAAEPDO6yUSBRithW2+gkjGNqo4qMX++MUDeYe9Xjm2lwHlZwmcwUFNQH7N/p5+NeRd4A==", "ab3f10de-828d-49fa-9f6e-415107158cd1" });
        }
    }
}
