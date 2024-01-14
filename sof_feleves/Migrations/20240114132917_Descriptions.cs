using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sof_feleves.Migrations
{
    public partial class Descriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "c40cd77b-498f-4501-a62f-a5cc868c2a0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a28cc7a0-909b-477f-b9a4-eae545f501df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "chiropractor_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0da8bb6-0d6d-45aa-a050-27102a87cfb3", "AQAAAAEAACcQAAAAEGEx6hR+7PBpnNOCLAEW1yAyeSlakjVWt+XZcRpq2g/5QhZK/YyZTdGZherJi0tokw==", "83284fcb-5900-41ef-bec7-1d7ddb959462" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dance_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21e9df3f-6963-44db-8d5d-f0358a89cdd1", "AQAAAAEAACcQAAAAEA5VtketXWdub9LPK5iTDjpD7s4BHtcjCEU6FvIfFy246CXVqm6Xis80BUqPkKWcrA==", "2d246b74-38e1-426c-b57d-d64f253c020d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "nail_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "728d9d2b-9794-49d2-9a4d-31f214ec72d6", "AQAAAAEAACcQAAAAEGsBauVu4sEoNXz1wympsdXBHbyjxwXgex0JI7GGDduhYsSp4rEuyAue5oR4P2HIyg==", "db885e7f-2f4a-4d10-bbd1-83b5f8c3b47c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "yoga_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1157d35e-c9df-43cf-8536-c444913d9e4b", "AQAAAAEAACcQAAAAEHOqt7m2os98IwtQGah+ulmb6WrY/m9+bmEuoLn75APlHZ0LIjAnkpAOM7thfnUdDQ==", "e1e9a5ce-cd27-4de5-8b2c-e768e9238883" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ID",
                keyValue: "chiropractor1",
                column: "Description",
                value: "Certified chiropractor - based in New York");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ID",
                keyValue: "dance_class1",
                column: "Description",
                value: "Contemporary dance class for creative minds");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ID",
                keyValue: "nail_salon1",
                column: "Description",
                value: "Luxury Nail salon located in the heart of London<3");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ID",
                keyValue: "yoga_class1",
                column: "Description",
                value: "Yoga for your body and mind at the yoga studio with your yoga host");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "ab4a94f6-6fa2-402b-b500-7b65f2116e7f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ccf38569-278f-4617-b6aa-84b54e3cb7ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "chiropractor_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a817f07-8291-48ac-88a7-b7b777ce97d1", "AQAAAAEAACcQAAAAEHYZCGR3cvc1KbDbLZSHsh3wWWMgJlhRyK0j8Xm39e27pcbPmkvDRF67tZGeSl20dw==", "7cf55ea8-12fd-4f39-aeee-ffb5da39c2bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dance_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c476b98-b02e-4b46-a31b-66ef80a3dad9", "AQAAAAEAACcQAAAAEOXDhceZZ+2WpnvnubR7l27M+6OaAO9y9lx8d5rpgHXz3hGBR3+EEoyEMtgv85Pnlw==", "2a4225e2-3102-4426-8ac5-0283b614a2da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "nail_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc6a729e-1cb4-407b-a86b-9b8495016cd9", "AQAAAAEAACcQAAAAECOLNpoLC99kvrre8UIr+ZRNU8n8k4fMq0mMn853/3KRAZDLr71FuGmyYrJe+W/Rjg==", "b9d4c590-95a8-44ed-b690-69224741671d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "yoga_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da5963ba-f6ee-4eeb-a8f0-939362378a2b", "AQAAAAEAACcQAAAAEE5wYowOTJcN+35YK5LwXWNF46N6JnMi8NSkyo79Ovx6dFkIWOkLvP0bJD/yvOEQQw==", "f836567c-f47c-4ac1-af5b-41504cdc2787" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ID",
                keyValue: "chiropractor1",
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ID",
                keyValue: "dance_class1",
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ID",
                keyValue: "nail_salon1",
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ID",
                keyValue: "yoga_class1",
                column: "Description",
                value: null);
        }
    }
}
