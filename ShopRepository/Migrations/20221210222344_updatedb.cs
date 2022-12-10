using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopRepository.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductModel_ItemModel_ItemID",
                table: "ProductModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductModel_ShopModel_ShopID",
                table: "ProductModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductModel",
                table: "ProductModel");

            migrationBuilder.RenameTable(
                name: "ProductModel",
                newName: "ProductFromShopAModel");

            migrationBuilder.RenameIndex(
                name: "IX_ProductModel_ShopID",
                table: "ProductFromShopAModel",
                newName: "IX_ProductFromShopAModel_ShopID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductModel_ItemID",
                table: "ProductFromShopAModel",
                newName: "IX_ProductFromShopAModel_ItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductFromShopAModel",
                table: "ProductFromShopAModel",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFromShopAModel_ItemModel_ItemID",
                table: "ProductFromShopAModel",
                column: "ItemID",
                principalTable: "ItemModel",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFromShopAModel_ShopModel_ShopID",
                table: "ProductFromShopAModel",
                column: "ShopID",
                principalTable: "ShopModel",
                principalColumn: "ShopId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFromShopAModel_ItemModel_ItemID",
                table: "ProductFromShopAModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFromShopAModel_ShopModel_ShopID",
                table: "ProductFromShopAModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductFromShopAModel",
                table: "ProductFromShopAModel");

            migrationBuilder.RenameTable(
                name: "ProductFromShopAModel",
                newName: "ProductModel");

            migrationBuilder.RenameIndex(
                name: "IX_ProductFromShopAModel_ShopID",
                table: "ProductModel",
                newName: "IX_ProductModel_ShopID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductFromShopAModel_ItemID",
                table: "ProductModel",
                newName: "IX_ProductModel_ItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductModel",
                table: "ProductModel",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductModel_ItemModel_ItemID",
                table: "ProductModel",
                column: "ItemID",
                principalTable: "ItemModel",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductModel_ShopModel_ShopID",
                table: "ProductModel",
                column: "ShopID",
                principalTable: "ShopModel",
                principalColumn: "ShopId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
