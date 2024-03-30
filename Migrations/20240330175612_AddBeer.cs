using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeBoozin.Migrations
{
    /// <inheritdoc />
    public partial class AddBeer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "AlcoholContent",
                table: "Products",
                type: "double",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "AlcoholContent", "Description" },
                values: new object[] { 40.0, "Feel the purity of your soul through this wonder drink." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "AlcoholContent",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AlcoholContent",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AlcoholContent",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "AlcoholContent",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "AlcoholContent",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "AlcoholContent",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "AlcoholContent",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "AlcoholContent",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "AlcoholContent",
                value: 45.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "AlcoholContent",
                value: 37.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "AlcoholContent",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "AlcoholContent",
                value: 42.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "AlcoholContent",
                value: 45.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "AlcoholContent",
                value: 45.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "AlcoholContent",
                value: 38.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "AlcoholContent",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "AlcoholContent",
                value: 40.0);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AlcoholContent", "CategoryId", "Description", "Image", "ProductName", "QuantityInMl", "QuantityInStock" },
                values: new object[,]
                {
                    { 19, 8.5, 3, "Feel the freshness of pine forest with this beer.", "/Photos/Beer1.webp", "Pine Forest", 500, 50 },
                    { 20, 6.5, 3, "Feel the breeze of Alps with this beer.", "/Photos/Beer2.webp", "Alpine Breeze", 500, 50 },
                    { 21, 7.0, 3, "Crafted with love and dedication by the Fine Brothers.", "/Photos/Beer3.webp", "Fine Brothers", 500, 50 },
                    { 22, 5.5, 3, "Brewed from the best golden wheat.", "/Photos/Beer4.webp", "Golden Wheat", 500, 50 },
                    { 23, 7.5, 3, "Fine dark beer for the bear in you.", "/Photos/Beer5.webp", "Bearish", 500, 50 },
                    { 24, 6.0, 3, "Brewed to be enjoyed with friends.", "/Photos/Beer6.webp", "Quality Time", 500, 50 },
                    { 25, 8.6999999999999993, 3, "Essential beer for every BBQ master.", "/Photos/Beer7.webp", "BBQ Master", 500, 50 },
                    { 26, 6.7999999999999998, 3, "Brewed in the traditional Bavarian style.", "/Photos/Beer8.webp", "Bavarian", 500, 50 },
                    { 27, 7.7000000000000002, 3, "Finest Dark beer from the Czech Republic.", "/Photos/Beer9.webp", "Czech Pride", 500, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.AlterColumn<decimal>(
                name: "AlcoholContent",
                table: "Products",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "AlcoholContent", "Description" },
                values: new object[] { 40m, "Feel the purity of your soul through this wonder drink" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "AlcoholContent",
                value: 40m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AlcoholContent",
                value: 40m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AlcoholContent",
                value: 40m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "AlcoholContent",
                value: 40m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "AlcoholContent",
                value: 40m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "AlcoholContent",
                value: 40m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "AlcoholContent",
                value: 40m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "AlcoholContent",
                value: 40m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "AlcoholContent",
                value: 45m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "AlcoholContent",
                value: 37m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "AlcoholContent",
                value: 40m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "AlcoholContent",
                value: 42m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "AlcoholContent",
                value: 45m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "AlcoholContent",
                value: 45m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "AlcoholContent",
                value: 38m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "AlcoholContent",
                value: 40m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "AlcoholContent",
                value: 40m);
        }
    }
}
