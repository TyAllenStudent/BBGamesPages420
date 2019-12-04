using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BBGamesPages420.Data.Migrations
{
    public partial class BBGameContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameTitle = table.Column<string>(nullable: true),
                    GameDate = table.Column<DateTime>(nullable: false),
                    Venue = table.Column<string>(nullable: true),
                    UserPaid = table.Column<string>(nullable: true),
                    PaidAmount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
