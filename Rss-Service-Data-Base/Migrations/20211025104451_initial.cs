using Microsoft.EntityFrameworkCore.Migrations;

namespace Rss_Service_Data_Base.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NuDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version = table.Column<double>(nullable: false),
                    Atom = table.Column<string>(nullable: true),
                    Dc = table.Column<string>(nullable: true),
                    Media = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NuDatabase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechRepublicDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Media = table.Column<string>(nullable: true),
                    Atom = table.Column<string>(nullable: true),
                    S = table.Column<string>(nullable: true),
                    Itunes = table.Column<string>(nullable: true),
                    Version = table.Column<double>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechRepublicDatabase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechVisorDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A10 = table.Column<string>(nullable: true),
                    Version = table.Column<double>(nullable: false),
                    Text = table.Column<string>(nullable: true)
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
