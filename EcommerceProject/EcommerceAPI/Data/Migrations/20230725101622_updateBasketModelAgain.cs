using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateBasketModelAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItemModel_BasketModel_BasketId",
                table: "CartItemModel");

            migrationBuilder.AlterColumn<int>(
                name: "BasketId",
                table: "CartItemModel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItemModel_BasketModel_BasketId",
                table: "CartItemModel",
                column: "BasketId",
                principalTable: "BasketModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItemModel_BasketModel_BasketId",
                table: "CartItemModel");

            migrationBuilder.AlterColumn<int>(
                name: "BasketId",
                table: "CartItemModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItemModel_BasketModel_BasketId",
                table: "CartItemModel",
                column: "BasketId",
                principalTable: "BasketModel",
                principalColumn: "Id");
        }
    }
}
