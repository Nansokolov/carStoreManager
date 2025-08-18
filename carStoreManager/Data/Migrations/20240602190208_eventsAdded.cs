using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carStoreManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class eventsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CarId",
                table: "CartItem",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Car_CarId",
                table: "CartItem",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Car_CarId",
                table: "CartItem");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_CarId",
                table: "CartItem");
        }
    }
}
