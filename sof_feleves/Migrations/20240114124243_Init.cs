using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace sof_feleves.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    SurName = table.Column<string>(type: "text", nullable: true),
                    ProfilePicContentType = table.Column<string>(type: "text", nullable: true),
                    ProfilePicData = table.Column<byte[]>(type: "bytea", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    HostID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Services_AspNetUsers_HostID",
                        column: x => x.HostID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MaxApplicants = table.Column<int>(type: "integer", nullable: false),
                    ServiceID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Appointments_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    ImageContentType = table.Column<string>(type: "text", nullable: true),
                    ImageData = table.Column<byte[]>(type: "bytea", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "AppointmentSiteUser",
                columns: table => new
                {
                    ApplicantsId = table.Column<string>(type: "text", nullable: false),
                    AppointmentsID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentSiteUser", x => new { x.ApplicantsId, x.AppointmentsID });
                    table.ForeignKey(
                        name: "FK_AppointmentSiteUser_Appointments_AppointmentsID",
                        column: x => x.AppointmentsID,
                        principalTable: "Appointments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentSiteUser_AspNetUsers_ApplicantsId",
                        column: x => x.ApplicantsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0", "ab4a94f6-6fa2-402b-b500-7b65f2116e7f", "Guest", "GUEST" },
                    { "1", "ccf38569-278f-4617-b6aa-84b54e3cb7ce", "Host", "HOST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicContentType", "ProfilePicData", "SecurityStamp", "SurName", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "chiropractor_host1", 0, "4a817f07-8291-48ac-88a7-b7b777ce97d1", "chiropractor@chiropractor.chiropractor", false, "Chiropractor", false, null, null, "CHIROPRACTOR", "AQAAAAEAACcQAAAAEHYZCGR3cvc1KbDbLZSHsh3wWWMgJlhRyK0j8Xm39e27pcbPmkvDRF67tZGeSl20dw==", null, false, null, null, "7cf55ea8-12fd-4f39-aeee-ffb5da39c2bc", "Master", false, null },
                    { "dance_host1", 0, "1c476b98-b02e-4b46-a31b-66ef80a3dad9", "dance@dance.dance", false, "Dance", false, null, null, "DANCE", "AQAAAAEAACcQAAAAEOXDhceZZ+2WpnvnubR7l27M+6OaAO9y9lx8d5rpgHXz3hGBR3+EEoyEMtgv85Pnlw==", null, false, null, null, "2a4225e2-3102-4426-8ac5-0283b614a2da", "Master", false, null },
                    { "nail_host1", 0, "bc6a729e-1cb4-407b-a86b-9b8495016cd9", "nail@nail.nail", false, "Nail", false, null, null, "NAIL", "AQAAAAEAACcQAAAAECOLNpoLC99kvrre8UIr+ZRNU8n8k4fMq0mMn853/3KRAZDLr71FuGmyYrJe+W/Rjg==", null, false, null, null, "b9d4c590-95a8-44ed-b690-69224741671d", "Master", false, null },
                    { "yoga_host1", 0, "da5963ba-f6ee-4eeb-a8f0-939362378a2b", "yoga@yoga.yoga", false, "Yoga", false, null, null, "YOGA", "AQAAAAEAACcQAAAAEE5wYowOTJcN+35YK5LwXWNF46N6JnMi8NSkyo79Ovx6dFkIWOkLvP0bJD/yvOEQQw==", null, false, null, null, "f836567c-f47c-4ac1-af5b-41504cdc2787", "Master", false, null }
                });

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

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ID", "Description", "HostID", "Location", "Name" },
                values: new object[,]
                {
                    { "chiropractor1", null, "chiropractor_host1", "New York", "Chiropractor" },
                    { "dance_class1", null, "dance_host1", "Dance Studio in Paris", "Dance class" },
                    { "nail_salon1", null, "nail_host1", "London Nail Salon", "Nail salon" },
                    { "yoga_class1", null, "yoga_host1", "Yoga Studio in Budapest", "Yoga class" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "ID", "Date", "MaxApplicants", "ServiceID" },
                values: new object[,]
                {
                    { "apt1", new DateTime(2025, 6, 28, 10, 0, 0, 0, DateTimeKind.Utc), 10, "yoga_class1" },
                    { "apt2", new DateTime(2025, 6, 28, 12, 0, 0, 0, DateTimeKind.Utc), 10, "yoga_class1" },
                    { "apt3", new DateTime(2025, 5, 5, 13, 30, 0, 0, DateTimeKind.Utc), 1, "nail_salon1" },
                    { "apt4", new DateTime(2025, 7, 28, 19, 0, 0, 0, DateTimeKind.Utc), 25, "dance_class1" },
                    { "apt5", new DateTime(2025, 7, 29, 19, 0, 0, 0, DateTimeKind.Utc), 25, "dance_class1" },
                    { "apt6", new DateTime(2025, 8, 28, 19, 0, 0, 0, DateTimeKind.Utc), 25, "dance_class1" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "ImageContentType", "ImageData", "ServiceID", "Text", "Title" },
                values: new object[,]
                {
                    { "post1", null, null, "yoga_class1", "Yoga for your body and mind at the yoga studio with your yoga host", "Yoga classes" },
                    { "post2", null, null, "dance_class1", "Unfortunately I have to cancel today's dance class because I have COVID. :( See you guys next week!", "TODAY'S CLASS IS CANCELED!" },
                    { "post3", null, null, "nail_salon1", "Hello guys, someone left their Gucci bag at my studio. Please come pick it up!", "Gucci bag left at studio!!" },
                    { "post4", null, null, "chiropractor1", "Dear Guests, please make sure you don't make a mess after yourself when using the toilet at my office. I had to clean for hours after someone pooped there...", "Someone clogged the toilet at my office..." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ServiceID",
                table: "Appointments",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSiteUser_AppointmentsID",
                table: "AppointmentSiteUser",
                column: "AppointmentsID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ServiceID",
                table: "Posts",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_HostID",
                table: "Services",
                column: "HostID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentSiteUser");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
