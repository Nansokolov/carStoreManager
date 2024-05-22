using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carStoreManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class changedefaultUserBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_AspNetUsers_AspNetUsersId",
                table: "Car");

            migrationBuilder.RenameColumn(
                name: "AspNetUsersId",
                table: "Car",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_AspNetUsersId",
                table: "Car",
                newName: "IX_Car_ApplicationUserId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_AspNetUsers_ApplicationUserId",
                table: "Car",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_AspNetUsers_ApplicationUserId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Car",
                newName: "AspNetUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_ApplicationUserId",
                table: "Car",
                newName: "IX_Car_AspNetUsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_AspNetUsers_AspNetUsersId",
                table: "Car",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
