using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetfirst.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Skill = table.Column<int>(nullable: false),
                    Expirience = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_players", x => x.PlayerId);
                });

            migrationBuilder.InsertData(
                table: "players",
                columns: new[] { "PlayerId", "Expirience", "Name", "Skill", "TeamId" },
                values: new object[] { -1, 85, "Ronaldo", 95, 1 });

            migrationBuilder.InsertData(
                table: "players",
                columns: new[] { "PlayerId", "Expirience", "Name", "Skill", "TeamId" },
                values: new object[] { -2, 79, "Messi", 93, 2 });

            migrationBuilder.InsertData(
                table: "players",
                columns: new[] { "PlayerId", "Expirience", "Name", "Skill", "TeamId" },
                values: new object[] { -3, 79, "Robinho", 76, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "players");
        }
    }
}
