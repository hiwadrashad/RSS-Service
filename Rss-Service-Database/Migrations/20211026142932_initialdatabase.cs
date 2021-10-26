using Microsoft.EntityFrameworkCore.Migrations;

namespace Rss_Service_Database.Migrations
{
    public partial class initialdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NuDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version = table.Column<double>(type: "float", nullable: false),
                    Atom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Media = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NuDatabase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechRepublicDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Media = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Itunes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechRepublicDatabase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechVisorDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechVisorDatabase", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NuDatabase");

            migrationBuilder.DropTable(
                name: "TechRepublicDatabase");

            migrationBuilder.DropTable(
                name: "TechVisorDatabase");
        }
    }
}
