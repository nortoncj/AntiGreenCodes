using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AntiGreenCodes.Server.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 3, "Roxanne : SWORD AND SHIELD ASTRAL RADIANCE 188/189 - Pokemon Single Card. Mint / near mint condition trading card.", "https://cdn.chaoscards.co.uk/uploads/prod_img/2_195828_e.png?v=1653661944", 30.00m, "Roxane" },
                    { 5, 1, "Galarian Articuno V : SWORD AND SHIELD - CHILLING REIGN - 169/198 - Pokemon Single Card", "https://cdn.chaoscards.co.uk/uploads/prod_img/2_177622_e.png?v=1623939679", 300.00m, "Articuno" },
                    { 6, 3, "Ultra Ball : SWORD AND SHIELD - BRILLIANT STARS 186/172 - Pokemon Single Card", "https://cdn.chaoscards.co.uk/uploads/prod_img/2_189981_e.png?v=1645795290", 20.00m, "UltraBall" },
                    { 7, 2, "Pokemon Trading Card Game Team Up Uncommon Pupitar #80", "https://imgs.search.brave.com/yOjMw_LpAcMeJutM-1CPipiXe322XgPR6-I7OUTY-Eo/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly9jZG4x/MS5iaWdjb21tZXJj/ZS5jb20vcy0wa3Z2/OS9pbWFnZXMvc3Rl/bmNpbC8yNTYwdy9w/cm9kdWN0cy8yODYx/NzYvNDAyMDc2L3Bv/a2Vtb250ZWFtdXAw/ODBfXzE1NTEwLjE1/NDkwNTEwNjMuanBn/P2M9Mg", 30.00m, "Pupitar" },
                    { 8, 1, "Pokemon Shining Fates Rare Celebi #3", "https://tools.toywiz.com/_images/_webp/_products/lg/pokemonshiningfates003.webp", 70.00m, "Celebi" },
                    { 9, 1, "Pokemon Gym Challenge Rare Holo Misty's Gyarados #13", "https://tools.toywiz.com/_images/_webp/_products/lg/pokemongc013.webp", 150.00m, "Gyarados" },
                    { 10, 1, "Pokemon Sword & Shield Evolving Skies Ultra Rare Rayquaza V #194", "https://tools.toywiz.com/_images/_webp/_products/lg/pokemonevolvingskies194.webp", 100.00m, "Rayquaza" },
                    { 11, 1, "Pokemon Astral Radiance Secret Rare Origin Form Palkia-VSTAR #208", "https://tools.toywiz.com/_images/_webp/_products/lg/pokemonastralradiance208.webp", 100.00m, "Palkia" },
                    { 12, 1, "Pokemon Astral Radiance Ultra Rare Origin Forme Dialga-V #177", "https://tools.toywiz.com/_images/_webp/_products/lg/pokemonastralradiance177.webp", 700.00m, "Dialga" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
