using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class addcustomertobasket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerModel_BasketModel_BasketId",
                table: "CustomerModel");

            migrationBuilder.DropIndex(
                name: "IX_CustomerModel_BasketId",
                table: "CustomerModel");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "CustomerModel");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "BasketModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BasketModel_CustomerId",
                table: "BasketModel",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketModel_CustomerModel_CustomerId",
                table: "BasketModel",
                column: "CustomerId",
                principalTable: "CustomerModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketModel_CustomerModel_CustomerId",
                table: "BasketModel");

            migrationBuilder.DropIndex(
                name: "IX_BasketModel_CustomerId",
                table: "BasketModel");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "BasketModel");

            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                table: "CustomerModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerModel_BasketId",
                table: "CustomerModel",
                column: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerModel_BasketModel_BasketId",
                table: "CustomerModel",
                column: "BasketId",
                principalTable: "BasketModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
