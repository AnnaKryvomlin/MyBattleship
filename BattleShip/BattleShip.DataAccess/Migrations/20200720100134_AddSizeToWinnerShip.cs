using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BattleShip.DataAccess.Migrations
{
    public partial class AddSizeToWinnerShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "WinnerShips",
                nullable: false,
                defaultValue: 0);
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "WinnerShips");
        }
    }
}
