﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopRepository.Migrations
{
    public partial class _20221217_1311 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFromShopAModel_ItemModel_ItemID",
                table: "ProductFromShopAModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFromShopAModel_ShopModel_ShopID",
                table: "ProductFromShopAModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFromShopBModel_ShopModel_ShopID",
                table: "ProductFromShopBModel");

            migrationBuilder.DropIndex(
                name: "IX_ProductFromShopBModel_ShopID",
                table: "ProductFromShopBModel");

            migrationBuilder.DropIndex(
                name: "IX_ProductFromShopAModel_ItemID",
                table: "ProductFromShopAModel");

            migrationBuilder.DropIndex(
                name: "IX_ProductFromShopAModel_ShopID",
                table: "ProductFromShopAModel");

            migrationBuilder.AlterColumn<int>(
                name: "ShopID",
                table: "ProductFromShopBModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ShopID",
                table: "ProductFromShopAModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ItemID",
                table: "ProductFromShopAModel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFromShopBModel_ShopID",
                table: "ProductFromShopBModel",
                column: "ShopID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFromShopAModel_ItemID",
                table: "ProductFromShopAModel",
                column: "ItemID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFromShopAModel_ShopID",
                table: "ProductFromShopAModel",
                column: "ShopID");

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
                principalColumn: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFromShopBModel_ShopModel_ShopID",
                table: "ProductFromShopBModel",
                column: "ShopID",
                principalTable: "ShopModel",
                principalColumn: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFromShopAModel_ItemModel_ItemID",
                table: "ProductFromShopAModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFromShopAModel_ShopModel_ShopID",
                table: "ProductFromShopAModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFromShopBModel_ShopModel_ShopID",
                table: "ProductFromShopBModel");

            migrationBuilder.DropIndex(
                name: "IX_ProductFromShopBModel_ShopID",
                table: "ProductFromShopBModel");

            migrationBuilder.DropIndex(
                name: "IX_ProductFromShopAModel_ItemID",
                table: "ProductFromShopAModel");

            migrationBuilder.DropIndex(
                name: "IX_ProductFromShopAModel_ShopID",
                table: "ProductFromShopAModel");

            migrationBuilder.AlterColumn<int>(
                name: "ShopID",
                table: "ProductFromShopBModel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShopID",
                table: "ProductFromShopAModel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemID",
                table: "ProductFromShopAModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFromShopBModel_ShopID",
                table: "ProductFromShopBModel",
                column: "ShopID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFromShopAModel_ItemID",
                table: "ProductFromShopAModel",
                column: "ItemID",
                unique: true,
                filter: "[ItemID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFromShopAModel_ShopID",
                table: "ProductFromShopAModel",
                column: "ShopID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFromShopAModel_ItemModel_ItemID",
                table: "ProductFromShopAModel",
                column: "ItemID",
                principalTable: "ItemModel",
                principalColumn: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFromShopAModel_ShopModel_ShopID",
                table: "ProductFromShopAModel",
                column: "ShopID",
                principalTable: "ShopModel",
                principalColumn: "ShopId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFromShopBModel_ShopModel_ShopID",
                table: "ProductFromShopBModel",
                column: "ShopID",
                principalTable: "ShopModel",
                principalColumn: "ShopId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}