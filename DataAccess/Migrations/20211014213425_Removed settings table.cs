using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Removedsettingstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Setting_SettingId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropIndex(
                name: "IX_Users_SettingId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SettingId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SettingId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_SettingId",
                table: "Users",
                column: "SettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Setting_SettingId",
                table: "Users",
                column: "SettingId",
                principalTable: "Setting",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
