using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopRepository.Migrations
{
    public partial class initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemModel",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemModel", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "ShopModel",
                columns: table => new
                {
                    ShopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopModel", x => x.ShopId);
                });

            migrationBuilder.CreateTable(
                name: "ProductFromShopBModel",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    ShopID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFromShopBModel", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductFromShopBModel_ItemModel_ItemID",
                        column: x => x.ItemID,
                        principalTable: "ItemModel",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFromShopBModel_ShopModel_ShopID",
                        column: x => x.ShopID,
                        principalTable: "ShopModel",
                        principalColumn: "ShopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductModel",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    ShopID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductModel", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductModel_ItemModel_ItemID",
                        column: x => x.ItemID,
                        principalTable: "ItemModel",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductModel_ShopModel_ShopID",
                        column: x => x.ShopID,
                        principalTable: "ShopModel",
                        principalColumn: "ShopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFromShopBModel_ItemID",
                table: "ProductFromShopBModel",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFromShopBModel_ShopID",
                table: "ProductFromShopBModel",
                column: "ShopID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductModel_ItemID",
                table: "ProductModel",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductModel_ShopID",
                table: "ProductModel",
                column: "ShopID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductFromShopBModel");

            migrationBuilder.DropTable(
                name: "ProductModel");

            migrationBuilder.DropTable(
                name: "ItemModel");

            migrationBuilder.DropTable(
                name: "ShopModel");
        }
    }
}
