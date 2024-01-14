using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sof_feleves.Migrations
{
    public partial class InitLocalDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePicContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePicData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostID = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaxApplicants = table.Column<int>(type: "int", nullable: false),
                    ServiceID = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ServiceID = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    ApplicantsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AppointmentsID = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0", "753b4a61-aeb9-4b23-bcd8-9159aa9822a4", "Guest", "GUEST" },
                    { "1", "d0e2b3dc-f76c-41d7-b422-c401dfecab6f", "Host", "HOST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicContentType", "ProfilePicData", "SecurityStamp", "SurName", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "chiropractor_host1", 0, "97d95a05-de5d-4dd9-ad98-859154542e2f", "chiropractor@chiropractor.chiropractor", false, "Chiropractor", false, null, null, "CHIROPRACTOR", "AQAAAAEAACcQAAAAELjA9UzQnOUlT8bgUXBOYzWK4QZnBwF6NzShBgCx0sTwj8EcROBHRwxlU6UGaSCn+g==", null, false, null, null, "b7228121-8e5e-41d9-81f7-2a3eb37e562b", "Master", false, null },
                    { "dance_host1", 0, "6d7663e9-d63e-45ce-a7e9-42afce2749d3", "dance@dance.dance", false, "Dance", false, null, null, "DANCE", "AQAAAAEAACcQAAAAEPfXKZ8UYLC9szKVwmO0fy9PrPna2yC4jb0ASL1NEqfIpwDX13KTnnPA9iWf7zCw0w==", null, false, null, null, "968876e3-bcca-4fa7-9560-e4013ffd4b3e", "Master", false, null },
                    { "nail_host1", 0, "91826431-5b55-416d-ab74-9de2eb57d856", "nail@nail.nail", false, "Nail", false, null, null, "NAIL", "AQAAAAEAACcQAAAAEDsKbQ1LFjJZC3nDASYcnbgo77Zo+/B2D6smVKOHmLqvGVShG5m22AfRVH58mRlTkw==", null, false, null, null, "26a53218-1f98-4af9-b147-7f1d8de44d66", "Master", false, null },
                    { "yoga_host1", 0, "2a7dee71-ef51-4ecc-af35-dea426a7b684", "yoga@yoga.yoga", false, "Yoga", false, null, null, "YOGA", "AQAAAAEAACcQAAAAEICZ12XvGDqfBQ4jKuuQq/lqsfNzOpRGa0pVCb0VJ26hyO9wwdZ1ovD7NK3bPJ6vqg==", null, false, null, null, "0fd8d2be-ae6c-4a66-a3bc-5d0ff65c1399", "Master", false, null }
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
                    { "chiropractor1", "Certified chiropractor - based in New York", "chiropractor_host1", "New York", "Chiropractor" },
                    { "dance_class1", "Contemporary dance class for creative minds", "dance_host1", "Dance Studio in Paris", "Dance class" },
                    { "nail_salon1", "Luxury Nail salon located in the heart of London<3", "nail_host1", "London Nail Salon", "Nail salon" },
                    { "yoga_class1", "Yoga for your body and mind at the yoga studio with your yoga host", "yoga_host1", "Yoga Studio in Budapest", "Yoga class" }
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
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
