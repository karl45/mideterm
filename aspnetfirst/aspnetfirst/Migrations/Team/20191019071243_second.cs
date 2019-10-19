using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetfirst.Migrations.Team
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "players",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Coach = table.Column<string>(nullable: true),
                    TotalSkill = table.Column<int>(nullable: false),
                    TotalExperience = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_players", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "Player",
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
                    table.PrimaryKey("PK_Player", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Player_players_TeamId",
                        column: x => x.TeamId,
                        principalTable: "players",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "players",
                columns: new[] { "TeamId", "Coach", "Description", "Name", "TotalExperience", "TotalSkill" },
                values: new object[] { 1, "Dias", "Italian club", "Juventus", 0, 0 });

            migrationBuilder.InsertData(
                table: "players",
                columns: new[] { "TeamId", "Coach", "Description", "Name", "TotalExperience", "TotalSkill" },
                values: new object[] { 2, "Moriis", "Spain club", "Barcelona", 0, 0 });

            migrationBuilder.InsertData(
                table: "players",
                columns: new[] { "TeamId", "Coach", "Description", "Name", "TotalExperience", "TotalSkill" },
                values: new object[] { 3, "Moriis", "Spain club", "Barcelona", 0, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamId",
                table: "Player",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "players");
        }
    }
}
