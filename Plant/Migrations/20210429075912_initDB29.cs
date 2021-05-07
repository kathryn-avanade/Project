using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant.Migrations
{
    public partial class initDB29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Garden",
                table: "Plants");

            migrationBuilder.AddColumn<int>(
                name: "GardenID",
                table: "Plants",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Gardens",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gardens", x => x.ID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_Gardens_GardenID",
                table: "Plants");

            migrationBuilder.DropTable(
                name: "Gardens");

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
    }
}
