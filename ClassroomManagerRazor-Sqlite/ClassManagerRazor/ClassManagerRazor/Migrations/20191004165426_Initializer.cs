using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassManagerRazor.Migrations
{
    public partial class Initializer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    fName = table.Column<string>(nullable: true),
                    mName = table.Column<string>(nullable: true),
                    lName = table.Column<string>(nullable: true),
                    eMail = table.Column<string>(nullable: true),
                    gitHub = table.Column<string>(nullable: true),
                    linkedIn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
