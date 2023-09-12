using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ogani.Data.Migrations
{
    /// <inheritdoc />
    public partial class Addeddescriptioncolumntotablecategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryDescription",
                table: "tbl_categories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryDescription",
                table: "tbl_categories");
        }
    }
}
