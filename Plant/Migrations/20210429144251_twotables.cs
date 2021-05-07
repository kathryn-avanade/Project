using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant.Migrations
{
    public partial class twotables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_Gardens_GardenID",
                table: "Plants");

            migrationBuilder.DropIndex(
                name: "IX_Plants_GardenID",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "GardenID",
                table: "Plants");

            migrationBuilder.AddColumn<string>(
                name: "Garden",
                table: "Plants",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Garden",
                table: "Plants");

            migrationBuilder.AddColumn<int>(
                name: "GardenID",
                table: "Plants",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plants_GardenID",
                table: "Plants",
                column: "GardenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_Gardens_GardenID",
                table: "Plants",
                column: "GardenID",
                principalTable: "Gardens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
