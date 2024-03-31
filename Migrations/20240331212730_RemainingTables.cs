using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeBoozin.Migrations
{
    /// <inheritdoc />
    public partial class RemainingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CategoryImage",
                value: "/Photos/Rum.webp");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "CategoryImage",
                value: "/Photos/Wine.webp");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CategoryImage",
                value: "/Photos/Champagne.webp");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AlcoholContent", "CategoryId", "Description", "Image", "ProductName", "QuantityInMl", "QuantityInStock" },
                values: new object[,]
                {
                    { 28, 40.0, 4, "The choice of every gentleman.", "/Photos/Whiskey1.webp", "Gentleman's Choice", 750, 50 },
                    { 29, 45.0, 4, "Free the wolf inside you with this fine whiskey.", "/Photos/Whiskey2.webp", "Dark Wolf", 750, 50 },
                    { 30, 40.0, 4, "Feel the pride of Ireland with this whiskey.", "/Photos/Whiskey3.webp", "Irish Pride", 750, 50 },
                    { 31, 38.0, 4, "Crafted to unite the world.", "/Photos/Whiskey4.webp", "United Together", 750, 50 },
                    { 32, 40.0, 4, "Dive into the infinity with this whiskey.", "/Photos/Whiskey5.webp", "Infinity", 750, 50 },
                    { 33, 42.0, 4, "Symbolizes the good old times through its unique taste.", "/Photos/Whiskey6.webp", "Golden Age of Whiskey", 750, 50 },
                    { 34, 43.0, 4, "The choice of every royal family.", "/Photos/Whiskey7.webp", "Royal Choice", 750, 50 },
                    { 35, 40.0, 4, "Crafted to be enjoyed in the dark night.", "/Photos/Whiskey8.webp", "Dark Night", 750, 50 },
                    { 36, 38.0, 4, "Become the shooter you always wanted to be.", "/Photos/Whiskey9.webp", "Shooter's", 750, 50 },
                    { 37, 40.0, 5, "Feel the freshness of morning dew with this gin.", "/Photos/Gin1.webp", "Morning Dew", 750, 50 },
                    { 38, 35.0, 5, "Feel the atmosphere of sunset on the beach with this gin.", "/Photos/Gin2.webp", "Sunset on the Beach", 750, 50 },
                    { 39, 43.0, 5, "Feel the chill of ice bath with this gin.", "/Photos/Gin3.webp", "Ice Bath", 750, 50 },
                    { 40, 40.0, 5, "For adventurous souls only.", "/Photos/Gin4.webp", "Alligator", 750, 50 },
                    { 41, 38.0, 5, "Brings calmness and tranquility to your soul.", "/Photos/Gin5.webp", "Serenity", 750, 50 },
                    { 42, 45.0, 5, "Adrenaline rush in a bottle.", "/Photos/Gin6.webp", "Fury", 750, 50 },
                    { 43, 40.0, 5, "Feel the British punch with this gin.", "/Photos/Gin7.webp", "Britih Punch", 750, 50 },
                    { 44, 45.0, 5, "Feel the heat of Texas with this gin.", "/Photos/Gin8.webp", "Texas Heat", 750, 50 },
                    { 45, 40.0, 5, "Answer the call of nature and live peacefully with your inner self.", "/Photos/Gin9.webp", "Nature Calls", 750, 50 },
                    { 46, 40.0, 6, "The choice of every pirate.", "/Photos/Rum1.webp", "Pirate's Choice", 750, 50 },
                    { 47, 42.0, 6, "Feel ocean's power with every sip.", "/Photos/Rum2.webp", "Sea Storm", 750, 50 },
                    { 48, 38.0, 6, "Feel the tranquility of Caribbean night with this rum.", "/Photos/Rum3.webp", "Caribbean Night", 750, 50 },
                    { 49, 40.0, 6, "For true partygoers only.", "/Photos/Rum4.webp", "Partygoer", 750, 50 },
                    { 50, 38.0, 6, "Taste from a different galaxy.", "/Photos/Rum5.webp", "Stellar", 750, 50 },
                    { 51, 40.0, 6, "Feel the mesmerizing beauty of an eclipse with this rum.", "/Photos/Rum6.webp", "Eclipse", 750, 50 },
                    { 52, 42.0, 6, "For real explorers of the world.", "/Photos/Rum7.webp", "Voyager", 750, 50 },
                    { 53, 40.0, 6, "Become a dreamer with the first sip of this rum.", "/Photos/Rum8.webp", "Dreamer", 750, 50 },
                    { 54, 38.0, 6, "Feel the warmth and vitality with every sip.", "/Photos/Rum9.webp", "Sunny Way", 750, 50 },
                    { 55, 35.0, 7, "Live and enjoy through the Oriental night with this liquor.", "/Photos/Liquor1.webp", "Oriental Night", 750, 50 },
                    { 56, 33.0, 7, "Become the dancing star of the night with this liquor.", "/Photos/Liquor2.webp", "Dancing Star", 750, 50 },
                    { 57, 30.0, 7, "Taste the sophisticated sweetness of fruits.", "/Photos/Liquor3.webp", "Sweet Fruit", 750, 50 },
                    { 58, 35.0, 7, "Ignite the spark of passion inside you.", "/Photos/Liquor4.webp", "Passion", 750, 50 },
                    { 59, 33.0, 7, "Taste like a garden in full bloom.", "/Photos/Liquor5.webp", "Garden Bloom", 750, 50 },
                    { 60, 33.0, 7, "White as snow. Pure as a soul.", "/Photos/Liquor6.webp", "Albino", 750, 50 },
                    { 61, 35.0, 7, "For an extravagant soul ready to dive into the unknown.", "/Photos/Liquor7.webp", "Extravaganza", 750, 50 },
                    { 62, 34.0, 7, "The taste is as beautiful as the night sky.", "/Photos/Liquor8.webp", "Night Sky", 750, 50 },
                    { 63, 35.0, 7, "Tje choice of every champion.", "/Photos/Liquor9.webp", "Champ's", 750, 50 },
                    { 64, 12.0, 8, "Sophistication and unity.", "/Photos/Wine1.webp", "Trinity", 750, 50 },
                    { 65, 12.5, 8, "Feel the elegance and romance in every sip.", "/Photos/Wine2.webp", "Elegant Romance", 750, 50 },
                    { 66, 13.300000000000001, 8, "You won't be able to resist this wine.", "/Photos/Wine3.webp", "Red Temptation", 750, 50 },
                    { 67, 11.5, 8, "Overflowing with energy and freshness.", "/Photos/Wine4.webp", "White Energy", 750, 50 },
                    { 68, 12.800000000000001, 8, "Premium wine for the queen in you.", "/Photos/Wine5.webp", "Queen's Throne", 750, 50 },
                    { 69, 13.0, 8, "Feel the royalty with every bottle.", "/Photos/Wine6.webp", "Red Crown", 750, 50 },
                    { 70, 11.9, 8, "Purity and excellence in every glass", "/Photos/Wine7.webp", "White Rose", 750, 50 },
                    { 71, 12.5, 8, "Rare and precious like gold.", "/Photos/Wine8.webp", "Gold Rose", 750, 50 },
                    { 72, 12.300000000000001, 8, "Let's you crete the atmosphere to share with your loved ones.", "/Photos/Wine9.webp", "Cozy Night", 750, 50 },
                    { 73, 12.5, 9, "The choice of every royal family.", "/Photos/Champagne1.webp", "Royal Club", 750, 50 },
                    { 74, 12.6, 9, "Feel the rich taste of this champagne.", "/Photos/Champagne2.webp", "Rich", 750, 50 },
                    { 75, 12.0, 9, "Feel yourself like a Russian noble with this champagne.", "/Photos/Champagne3.webp", "Russian Nobility", 750, 50 },
                    { 76, 13.800000000000001, 9, "Stong and powerful like a dynasty.", "/Photos/Champagne4.webp", "Dynasty", 750, 50 },
                    { 77, 12.5, 9, "Invoke the desire for something you deserve.", "/Photos/Champagne5.webp", "Desire", 750, 50 },
                    { 78, 14.0, 9, "Rare and glorious like a diamond.", "/Photos/Champagne6.webp", "Rare Glory", 750, 50 },
                    { 79, 13.699999999999999, 9, "Fine Italian champagne for the connoisseurs.", "/Photos/Champagne7.webp", "Apennini", 750, 50 },
                    { 80, 14.5, 9, "The pleasure you won't be able to resist.", "/Photos/Champagne8.webp", "Guilty Pleasure", 750, 50 },
                    { 81, 13.4, 9, "Makes you enjoy every sip like it was your last romance", "/Photos/Champagne9.webp", "Last Romance", 750, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CategoryImage",
                value: "/Photos/Rum3.webp");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "CategoryImage",
                value: "/Photos/Wine2.webp");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CategoryImage",
                value: "/Photos/Champagne2.webp");
        }
    }
}
