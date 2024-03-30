using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeBoozin.Migrations
{
    /// <inheritdoc />
    public partial class VodkaProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Image", "ProductName", "QuantityInMl", "QuantityInStock" },
                values: new object[,]
                {
                    { 1, 1, "Feel the purity of your soul through this wonder drink", "/Photos/Vodka1.webp", "Purity of Soul", 750, 50 },
                    { 2, 1, "Feel the fire in your heart with this vodka designed to lit your soul.", "/Photos/Vodka2.webp", "Fire in the Heart", 750, 50 },
                    { 3, 1, "Feel the lightness in your soul with every sip of this vodka.", "/Photos/Vodka3.webp", "Lightness of Soul", 750, 50 },
                    { 4, 1, "Feel the freedom of your mind through after the first sip of this vodka.", "/Photos/Vodka4.webp", "Freedom of Mind", 750, 50 },
                    { 5, 1, "Feel the victory in your veins with this vodka.", "/Photos/Vodka5.webp", "Victorious", 750, 50 },
                    { 6, 1, "Feel the strength in your veins with this vodka.", "/Photos/Vodka6.webp", "Russian Power", 750, 50 },
                    { 7, 1, "Feel the glory like a Russian with this vodka.", "/Photos/Vodka7.webp", "Russian Glory", 750, 50 },
                    { 8, 1, "Become an alpha of your pac after the first sip of this vodka.", "/Photos/Vodka8.webp", "Alpha Male", 750, 50 },
                    { 9, 1, "Become an elite with this vodka.", "/Photos/Vodka9.webp", "World ELite", 750, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);
        }
    }
}
