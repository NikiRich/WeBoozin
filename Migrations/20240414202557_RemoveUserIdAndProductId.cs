using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeBoozin.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUserIdAndProductId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracker_Products_ProductId",
                table: "Tracker");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracker_Users_UserId",
                table: "Tracker");

            migrationBuilder.DropIndex(
                name: "IX_Tracker_ProductId",
                table: "Tracker");

            migrationBuilder.DropIndex(
                name: "IX_Tracker_UserId",
                table: "Tracker");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Tracker");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tracker");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Tracker",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tracker",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tracker_ProductId",
                table: "Tracker",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracker_UserId",
                table: "Tracker",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracker_Products_ProductId",
                table: "Tracker",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracker_Users_UserId",
                table: "Tracker",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
