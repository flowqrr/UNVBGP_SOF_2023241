using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sof_feleves.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    HostID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ID", "HostID", "Name" },
                values: new object[,]
                {
                    { "chiropractor1", "chiropractor_host1", "Chiropractor" },
                    { "dance_class1", "dance_host1", "Dance class" },
                    { "nail_salon1", "nail_host1", "Nail salon" },
                    { "yoga_class1", "yoga_host1", "Yoga class" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
