using Microsoft.EntityFrameworkCore.Migrations;

namespace HierarchyGUI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "getAuthentication",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Admin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_getAuthentication", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "getGroup",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Commander = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Motto = table.Column<string>(nullable: true),
                    Mission = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_getGroup", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "getHeadquartersAF",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    SecAF = table.Column<string>(nullable: true),
                    ChiefOfStaff = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_getHeadquartersAF", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "getMajcom",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Commander = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Motto = table.Column<string>(nullable: true),
                    Mission = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_getMajcom", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "getNumberedAF",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Commander = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Motto = table.Column<string>(nullable: true),
                    Mission = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_getNumberedAF", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "getSquadron",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Commander = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Motto = table.Column<string>(nullable: true),
                    Mission = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_getSquadron", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "getWing",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Commander = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Motto = table.Column<string>(nullable: true),
                    Mission = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_getWing", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "getAuthentication");

            migrationBuilder.DropTable(
                name: "getGroup");

            migrationBuilder.DropTable(
                name: "getHeadquartersAF");

            migrationBuilder.DropTable(
                name: "getMajcom");

            migrationBuilder.DropTable(
                name: "getNumberedAF");

            migrationBuilder.DropTable(
                name: "getSquadron");

            migrationBuilder.DropTable(
                name: "getWing");
        }
    }
}
