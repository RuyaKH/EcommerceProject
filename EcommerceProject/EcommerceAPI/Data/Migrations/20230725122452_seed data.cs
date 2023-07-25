using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WishlistModel_CustomerId",
                table: "WishlistModel");

            migrationBuilder.DropIndex(
                name: "IX_BasketModel_CustomerId",
                table: "BasketModel");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "CustomerModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistModel_CustomerId",
                table: "WishlistModel",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketModel_CustomerId",
                table: "BasketModel",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WishlistModel_CustomerId",
                table: "WishlistModel");

            migrationBuilder.DropIndex(
                name: "IX_BasketModel_CustomerId",
                table: "BasketModel");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "CustomerModel");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistModel_CustomerId",
                table: "WishlistModel",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasketModel_CustomerId",
                table: "BasketModel",
                column: "CustomerId",
                unique: true);
        }
    }
}
