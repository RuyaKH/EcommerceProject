using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductModel_WishlistModel_WishlistId",
                table: "ProductModel");

            migrationBuilder.DropIndex(
                name: "IX_ProductModel_WishlistId",
                table: "ProductModel");

            migrationBuilder.DropColumn(
                name: "WishlistId",
                table: "ProductModel");

            migrationBuilder.AddColumn<int>(
                name: "WishlistId",
                table: "CartItemModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItemModel_WishlistId",
                table: "CartItemModel",
                column: "WishlistId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItemModel_WishlistModel_WishlistId",
                table: "CartItemModel",
                column: "WishlistId",
                principalTable: "WishlistModel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItemModel_WishlistModel_WishlistId",
                table: "CartItemModel");

            migrationBuilder.DropIndex(
                name: "IX_CartItemModel_WishlistId",
                table: "CartItemModel");

            migrationBuilder.DropColumn(
                name: "WishlistId",
                table: "CartItemModel");

            migrationBuilder.AddColumn<int>(
                name: "WishlistId",
                table: "ProductModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductModel_WishlistId",
                table: "ProductModel",
                column: "WishlistId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductModel_WishlistModel_WishlistId",
                table: "ProductModel",
                column: "WishlistId",
                principalTable: "WishlistModel",
                principalColumn: "Id");
        }
    }
}
