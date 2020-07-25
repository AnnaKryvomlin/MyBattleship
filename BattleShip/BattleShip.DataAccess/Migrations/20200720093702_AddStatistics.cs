using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BattleShip.DataAccess.Migrations
{
    public partial class AddStatistics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "StatisticsRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<string>(nullable: true),
                    MoveCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticsRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WinnerShips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InjuredCells = table.Column<int>(nullable: true),
                    StatisticsRecordId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinnerShips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinnerShips_StatisticsRecords_StatisticsRecordId",
                        column: x => x.StatisticsRecordId,
                        principalTable: "StatisticsRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });                
           

            migrationBuilder.CreateIndex(
                name: "IX_WinnerShips_StatisticsRecordId",
                table: "WinnerShips",
                column: "StatisticsRecordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.DropTable(
                name: "WinnerShips");

          
            migrationBuilder.DropTable(
                name: "StatisticsRecords");


        }
    }
}
