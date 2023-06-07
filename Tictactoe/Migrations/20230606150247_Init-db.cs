using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tictactoe.Migrations
{
    /// <inheritdoc />
    public partial class Initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 25, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerXid = table.Column<int>(type: "int", nullable: false),
                    PlayerYid = table.Column<int>(type: "int", nullable: false),
                    board = table.Column<int>(type: "int", nullable: false),
                    winner = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
