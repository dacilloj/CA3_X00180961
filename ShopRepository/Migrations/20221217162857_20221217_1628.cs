using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopRepository.Migrations
{
    public partial class _20221217_1628 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFromShopAModel_ItemModel_ItemID",
                table: "ProductFromShopAModel");

            migrationBuilder.DropIndex(
                name: "IX_ProductFromShopAModel_ItemID",
                table: "ProductFromShopAModel");

            migrationBuilder.DropColumn(
                name: "ProductAID",
                table: "ItemModel");

            migrationBuilder.DropColumn(
                name: "ProductBID",
                table: "ItemModel");

            migrationBuilder.AlterColumn<int>(
                name: "ItemID",
                table: "ProductFromShopAModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFromShopAModel_ItemID",
                table: "ProductFromShopAModel",
                column: "ItemID",
                unique: true,
                filter: "[ItemID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFromShopAModel_ItemModel_ItemID",
                table: "ProductFromShopAModel",
                column: "ItemID",
                principalTable: "ItemModel",
                principalColumn: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFromShopAModel_ItemModel_ItemID",
                table: "ProductFromShopAModel");

            migrationBuilder.DropIndex(
                name: "IX_ProductFromShopAModel_ItemID",
                table: "ProductFromShopAModel");

            migrationBuilder.AlterColumn<int>(
                name: "ItemID",
                table: "ProductFromShopAModel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductFromShopAModel_ItemID",
                table: "ProductFromShopAModel",
                column: "ItemID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFromShopAModel_ItemModel_ItemID",
                table: "ProductFromShopAModel",
                column: "ItemID",
                principalTable: "ItemModel",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
