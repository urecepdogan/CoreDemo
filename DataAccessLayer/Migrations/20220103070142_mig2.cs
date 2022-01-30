using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgrenciID",
                table: "FiyatTeklifs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FiyatTeklifs_OgrenciID",
                table: "FiyatTeklifs",
                column: "OgrenciID");

            migrationBuilder.AddForeignKey(
                name: "FK_FiyatTeklifs_OgrenciBilgies_OgrenciID",
                table: "FiyatTeklifs",
                column: "OgrenciID",
                principalTable: "OgrenciBilgies",
                principalColumn: "OgrenciID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FiyatTeklifs_OgrenciBilgies_OgrenciID",
                table: "FiyatTeklifs");

            migrationBuilder.DropIndex(
                name: "IX_FiyatTeklifs_OgrenciID",
                table: "FiyatTeklifs");

            migrationBuilder.DropColumn(
                name: "OgrenciID",
                table: "FiyatTeklifs");
        }
    }
}
