using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sof_feleves.Migrations
{
    public partial class posts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Services",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    ServiceID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Posts_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ServiceID",
                table: "Posts",
                column: "ServiceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Services");

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
    }
}
