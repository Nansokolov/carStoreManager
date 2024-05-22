using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carStoreManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class addURLCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Car",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "Car");
        }
    }
}
