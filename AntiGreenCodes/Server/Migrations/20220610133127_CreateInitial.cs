using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AntiGreenCodes.Server.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 1, "Rare", "rare" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 2, "Pokemon Go", "pokemon-go" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 3, "Sword & Shield", "sword-and-shield" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, 1, "Pokemon Promo Single Charizard Oversized Card #4/102. Card measures approximately 8x6", "https://imgs.search.brave.com/tm0MvvNfuLuBiczH_exNEcVJy3gUpfXugRk1NMoGAbE/rs:fit:500:687:1/g:ce/aHR0cHM6Ly93d3cu/c2VsbDJiYm5vdmVs/dGllcy5jb20vbW01/L3Bva2Vtb24vUEtf/QjJfaDQuanBn", 300.00m, "Charizard" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, 3, "Pokemon Sword & Shield Base Set Rare Holo Cinderace", "https://imgs.search.brave.com/zu3PB4vXaoR4oOiIa6w_uTcSy9e8x3Ek-hpjTLSBNFQ/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly9jZG4x/MS5iaWdjb21tZXJj/ZS5jb20vcy0wa3Z2/OS9pbWFnZXMvc3Rl/bmNpbC8xOTIwdy9w/cm9kdWN0cy8zMjEy/MjMvNDY0MTU4L3Bv/a2Vtb25zd29yZDI2/c2hpZWxkMDM1X182/MjU2OC4xNTgwNzY3/MzI5LmpwZz9jPTI", 500.00m, "Cinderace" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, 1, "Pokemon Promo Single Mew Card", "https://imgs.search.brave.com/BUKX4p_Xu2peOCKs4Ehj_CeFHptCai02zhPu-Tj3TWM/rs:fit:1000:1200:1/g:ce/aHR0cHM6Ly9pNS53/YWxtYXJ0aW1hZ2Vz/LmNvbS9hc3IvY2M0/ZDQ3Y2QtMWIwMi00/Yzg4LWJhNWEtMjVj/MjBkMWVkNzdiXzEu/YzZlOGFkZTA4ODgw/YmMyOTVhY2E1Y2Q2/ZDc1N2Q0NzUuanBl/Zw", 700.00m, "Mew" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
