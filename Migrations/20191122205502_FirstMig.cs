using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hostility_Skirmish.Migrations
{
    public partial class FirstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    GameStateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.LogId);
                    table.ForeignKey(
                        name: "FK_Log_GameStates_GameStateId",
                        column: x => x.GameStateId,
                        principalTable: "GameStates",
                        principalColumn: "GameStateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Log_GameStateId",
                table: "Log",
                column: "GameStateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Log");
        }
    }
}
