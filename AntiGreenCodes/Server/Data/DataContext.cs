namespace AntiGreenCodes.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Rare",
                    Url = "rare"
                },
                new Category
                {
                    Id = 2,
                    Name = "Pokemon Go",
                    Url = "pokemon-go"
                },
                new Category
                {
                    Id = 3,
                    Name = "Sword & Shield",
                    Url = "sword-and-shield"
                });



            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Charizard",
                     Description = "Pokemon Promo Single Charizard Oversized Card #4/102. Card measures approximately 8x6",
                     ImageUrl = "https://imgs.search.brave.com/tm0MvvNfuLuBiczH_exNEcVJy3gUpfXugRk1NMoGAbE/rs:fit:500:687:1/g:ce/aHR0cHM6Ly93d3cu/c2VsbDJiYm5vdmVs/dGllcy5jb20vbW01/L3Bva2Vtb24vUEtf/QjJfaDQuanBn",
                     Price = 300.00m,
                     CategoryId= 1

                 },
            new Product
            {
                Id = 2,
                Title = "Cinderace",
                Description = "Pokemon Sword & Shield Base Set Rare Holo Cinderace",
                ImageUrl = "https://imgs.search.brave.com/zu3PB4vXaoR4oOiIa6w_uTcSy9e8x3Ek-hpjTLSBNFQ/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly9jZG4x/MS5iaWdjb21tZXJj/ZS5jb20vcy0wa3Z2/OS9pbWFnZXMvc3Rl/bmNpbC8xOTIwdy9w/cm9kdWN0cy8zMjEy/MjMvNDY0MTU4L3Bv/a2Vtb25zd29yZDI2/c2hpZWxkMDM1X182/MjU2OC4xNTgwNzY3/MzI5LmpwZz9jPTI",
                Price = 500.00m,
                CategoryId = 3

            },
            new Product
            {
                Id = 3,
                Title = "Mew",
                Description = "Pokemon Promo Single Mew Card",
                ImageUrl = "https://imgs.search.brave.com/BUKX4p_Xu2peOCKs4Ehj_CeFHptCai02zhPu-Tj3TWM/rs:fit:1000:1200:1/g:ce/aHR0cHM6Ly9pNS53/YWxtYXJ0aW1hZ2Vz/LmNvbS9hc3IvY2M0/ZDQ3Y2QtMWIwMi00/Yzg4LWJhNWEtMjVj/MjBkMWVkNzdiXzEu/YzZlOGFkZTA4ODgw/YmMyOTVhY2E1Y2Q2/ZDc1N2Q0NzUuanBl/Zw",
                Price = 700.00m,
                CategoryId = 1
               

            },
            new Product
            {
                Id = 4,
                Title = "Roxane",
                Description = "Roxanne : SWORD AND SHIELD ASTRAL RADIANCE 188/189 - Pokemon Single Card. Mint / near mint condition trading card.",
                ImageUrl = "https://cdn.chaoscards.co.uk/uploads/prod_img/2_195828_e.png?v=1653661944",
                Price = 30.00m,
                CategoryId = 3


            },
            new Product
            {
                Id = 5,
                Title = "Articuno",
                Description = "Galarian Articuno V : SWORD AND SHIELD - CHILLING REIGN - 169/198 - Pokemon Single Card",
                ImageUrl = "https://cdn.chaoscards.co.uk/uploads/prod_img/2_177622_e.png?v=1623939679",
                Price = 300.00m,
                CategoryId = 1


            },
            new Product
            {
                Id = 6,
                Title = "UltraBall",
                Description = "Ultra Ball : SWORD AND SHIELD - BRILLIANT STARS 186/172 - Pokemon Single Card",
                ImageUrl = "https://cdn.chaoscards.co.uk/uploads/prod_img/2_189981_e.png?v=1645795290",
                Price = 20.00m,
                CategoryId = 3


            }, new Product
            {
                Id = 7,
                Title = "Pupitar",
                Description = "Pokemon Trading Card Game Team Up Uncommon Pupitar #80",
                ImageUrl = "https://imgs.search.brave.com/yOjMw_LpAcMeJutM-1CPipiXe322XgPR6-I7OUTY-Eo/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly9jZG4x/MS5iaWdjb21tZXJj/ZS5jb20vcy0wa3Z2/OS9pbWFnZXMvc3Rl/bmNpbC8yNTYwdy9w/cm9kdWN0cy8yODYx/NzYvNDAyMDc2L3Bv/a2Vtb250ZWFtdXAw/ODBfXzE1NTEwLjE1/NDkwNTEwNjMuanBn/P2M9Mg",
                Price = 30.00m,
                CategoryId = 2

            },
            new Product
            {
                Id = 8,
                Title = "Celebi",
                Description = "Pokemon Shining Fates Rare Celebi #3",
                ImageUrl = "https://tools.toywiz.com/_images/_webp/_products/lg/pokemonshiningfates003.webp",
                Price = 70.00m,
                CategoryId = 1

            },
            new Product
            {
                Id = 9,
                Title = "Gyarados",
                Description = "Pokemon Gym Challenge Rare Holo Misty's Gyarados #13",
                ImageUrl = "https://tools.toywiz.com/_images/_webp/_products/lg/pokemongc013.webp",
                Price = 150.00m,
                CategoryId = 1


            },
            new Product
            {
                Id = 10,
                Title = "Rayquaza",
                Description = "Pokemon Sword & Shield Evolving Skies Ultra Rare Rayquaza V #194",
                ImageUrl = "https://tools.toywiz.com/_images/_webp/_products/lg/pokemonevolvingskies194.webp",
                Price = 100.00m,
                CategoryId = 1


            },
            new Product
            {
                Id = 11,
                Title = "Palkia",
                Description = "Pokemon Astral Radiance Secret Rare Origin Form Palkia-VSTAR #208",
                ImageUrl = "https://tools.toywiz.com/_images/_webp/_products/lg/pokemonastralradiance208.webp",
                Price = 100.00m,
                CategoryId = 1


            },
            new Product
            {
                Id = 12,
                Title = "Dialga",
                Description = "Pokemon Astral Radiance Ultra Rare Origin Forme Dialga-V #177",
                ImageUrl = "https://tools.toywiz.com/_images/_webp/_products/lg/pokemonastralradiance177.webp",
                Price = 700.00m,
                CategoryId = 1


            });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
