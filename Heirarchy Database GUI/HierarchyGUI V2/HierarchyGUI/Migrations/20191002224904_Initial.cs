using Microsoft.EntityFrameworkCore.Migrations;

namespace HierarchyGUI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Credentials",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Admin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credentials", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
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
                    table.PrimaryKey("PK_Groups", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "HeadquartersAF",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    SecAF = table.Column<string>(nullable: true),
                    ChiefOfStaff = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadquartersAF", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Majcoms",
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
                    table.PrimaryKey("PK_Majcoms", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "NumberedAFs",
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
                    table.PrimaryKey("PK_NumberedAFs", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Squadrons",
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
                    table.PrimaryKey("PK_Squadrons", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Wings",
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
                    table.PrimaryKey("PK_Wings", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Credentials");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "HeadquartersAF");

            migrationBuilder.DropTable(
                name: "Majcoms");

            migrationBuilder.DropTable(
                name: "NumberedAFs");

            migrationBuilder.DropTable(
                name: "Squadrons");

            migrationBuilder.DropTable(
                name: "Wings");
        }
    }
}
