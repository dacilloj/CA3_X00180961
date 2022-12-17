using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopRepository.Migrations
{
    public partial class _20221217_1606 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductAID",
                table: "ItemModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductBID",
                table: "ItemModel",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductAID",
                table: "ItemModel");

            migrationBuilder.DropColumn(
                name: "ProductBID",
                table: "ItemModel");
        }
    }
}
