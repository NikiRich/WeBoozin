using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeBoozin.Migrations
{
    /// <inheritdoc />
    public partial class AlcoholContentAndTequila : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AlcoholContent",
                table: "Products",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "AlcoholContent",
                value: 40m);

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AlcoholContent", "CategoryId", "Description", "Image", "ProductName", "QuantityInMl", "QuantityInStock" },
                values: new object[,]
                {
                    { 10, 45m, 2, "Live through the fire of Latino culture.", "/Photos/Tequila1.webp", "Latino Fire", 750, 50 },
                    { 11, 37m, 2, "Feel the pride of Mexico with this tequila.", "/Photos/Tequila2.webp", "Mexican Pride", 750, 50 },
                    { 12, 40m, 2, "Experience the Mexican fiesta at your home.", "/Photos/Tequila3.webp", "Fiesta", 750, 50 },
                    { 13, 42m, 2, "From the people. For the people. Live it.", "/Photos/Tequila4.webp", "Los Bandidos", 750, 50 },
                    { 14, 45m, 2, "Show you have got what it takes to earn it.", "/Photos/Tequila5.webp", "Blood Money", 750, 50 },
                    { 15, 45m, 2, "Celebrate the day of the dead with this tequila.", "/Photos/Tequila6.webp", "Dia de Muertos", 750, 50 },
                    { 16, 38m, 2, "Feel like a boss of the table with this tequila.", "/Photos/Tequila7.webp", "El Patron", 750, 50 },
                    { 17, 40m, 2, "Live through the Mexican night with this tequila.", "/Photos/Tequila8.webp", "Mexican Night", 750, 50 },
                    { 18, 40m, 2, "Meet and greet the Mexican sunrise with this tequila.", "/Photos/Tequila9.webp", "Mexican Sunrise", 750, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DropColumn(
                name: "AlcoholContent",
                table: "Products");
        }
    }
}
