using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sof_feleves.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0", "64f0b2bc-4d79-4aaf-bf91-8a5adccbfcec", "Guest", "GUEST" },
                    { "1", "a7c9a7c5-dec1-4c77-b81e-dd690be9953b", "Host", "HOST" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "chiropractor_host1" },
                    { "1", "dance_host1" },
                    { "1", "nail_host1" },
                    { "1", "yoga_host1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "chiropractor_host1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "dance_host1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "nail_host1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "yoga_host1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "chiropractor_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02bd6c3f-27f3-4ebd-bec5-76e1f16f6c6c", null, "40936ace-219f-4435-a80a-6ed9b784083b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dance_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f8083bd-8b9f-4177-83a0-0660fed2ad25", null, "c1572c36-e0f2-47e6-994c-b17b53dd166f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "nail_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fff85fba-2672-4695-9522-dcdbeabe2250", null, "83493925-4102-4e25-af57-609509c34062" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "yoga_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ab54ec8-43fa-4460-8e59-1bf4eb25de0e", null, "49fce046-55c5-45a2-b63b-98e5e20ec2d9" });
        }
    }
}
