using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sof_feleves.Migrations
{
    public partial class AppointmentApplicants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "37f4b539-f062-46a1-af6c-1fa35edb574c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8a2a271f-48a4-4726-bb19-49919628a055");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "chiropractor_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfb4c69d-eb8b-4ab9-96d4-f0a93242c057", "AQAAAAEAACcQAAAAEBwfHc9Vcx0lb2QOg4xbnBsqt+05eCoZLhp/jn7JRH4T2KN+HWg3eKJ4TW5b+600Hg==", "720e63bb-3b5e-4657-9a1a-5b5c3b2a8627" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dance_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e6bd094-d6a3-4b21-b186-5be78534dd20", "AQAAAAEAACcQAAAAEPjkrMG4kQUVHnLic4Lr01wgfHgb0ALMw8pmHYqrK2ASMaNQu4MfpoQdttwqlGykEA==", "20fdd676-b699-4926-9335-640e3b439ca1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "nail_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68aa1e06-cff0-4826-946d-74d13bae6084", "AQAAAAEAACcQAAAAEPhxrLiicnrGVJuuNM81iGGRvU6bo5NhRbWuIr1/Ivl2r3BoTQgvU68pUuskkB+zSQ==", "40589282-23c4-4ad7-9200-85fd99aea82e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "yoga_host1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fea9976-2de8-4b65-bedc-ec048d859d05", "AQAAAAEAACcQAAAAEKzd0bN/Gsk1hkyBRwmsNv6uhmrKHlpKsHQOoddAKGkK/2Ro1BdLxxKnkUJRTt0+PA==", "01227160-d60a-416e-a981-28853cbc1726" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
