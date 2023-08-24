using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedProductsAndCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Color = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_tbl_products_tbl_categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "tbl_categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade, onUpdate: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_product_review",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_product_review", x => new { x.ProductID, x.UserID });
                    table.ForeignKey(
                        name: "FK_tbl_product_review_tbl_products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "tbl_products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade, onUpdate: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_product_review_tbl_users_UserID",
                        column: x => x.UserID,
                        principalTable: "tbl_users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.NoAction, onUpdate: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_product_review_UserID",
                table: "tbl_product_review",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_products_CategoryID",
                table: "tbl_products",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_product_review");

            migrationBuilder.DropTable(
                name: "tbl_products");

            migrationBuilder.DropTable(
                name: "tbl_users");

            migrationBuilder.DropTable(
                name: "tbl_categories");
        }
    }
}
