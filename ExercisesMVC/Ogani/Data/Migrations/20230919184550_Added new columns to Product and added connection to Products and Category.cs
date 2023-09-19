using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ogani.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddednewcolumnstoProductandaddedconnectiontoProductsandCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "tbl_products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfEdit",
                table: "tbl_products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductCategoryCategoryID",
                table: "tbl_products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_tbl_products_ProductCategoryCategoryID",
                table: "tbl_products",
                column: "ProductCategoryCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_products_tbl_categories_ProductCategoryCategoryID",
                table: "tbl_products",
                column: "ProductCategoryCategoryID",
                principalTable: "tbl_categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_products_tbl_categories_ProductCategoryCategoryID",
                table: "tbl_products");

            migrationBuilder.DropIndex(
                name: "IX_tbl_products_ProductCategoryCategoryID",
                table: "tbl_products");

            migrationBuilder.DropColumn(
                name: "DateOfCreation",
                table: "tbl_products");

            migrationBuilder.DropColumn(
                name: "DateOfEdit",
                table: "tbl_products");

            migrationBuilder.DropColumn(
                name: "ProductCategoryCategoryID",
                table: "tbl_products");
        }
    }
}
