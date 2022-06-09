namespace AntiGreenCodes.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Charizard",
                     Description = "Pokemon Promo Single Charizard Oversized Card #4/102. Card measures approximately 8x6",
                     ImageUrl = "https://imgs.search.brave.com/tm0MvvNfuLuBiczH_exNEcVJy3gUpfXugRk1NMoGAbE/rs:fit:500:687:1/g:ce/aHR0cHM6Ly93d3cu/c2VsbDJiYm5vdmVs/dGllcy5jb20vbW01/L3Bva2Vtb24vUEtf/QjJfaDQuanBn",
                     Price = 300.00m

                 },
            new Product
            {
                Id = 2,
                Title = "Cinderace",
                Description = "Pokemon Sword & Shield Base Set Rare Holo Cinderace",
                ImageUrl = "https://imgs.search.brave.com/zu3PB4vXaoR4oOiIa6w_uTcSy9e8x3Ek-hpjTLSBNFQ/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly9jZG4x/MS5iaWdjb21tZXJj/ZS5jb20vcy0wa3Z2/OS9pbWFnZXMvc3Rl/bmNpbC8xOTIwdy9w/cm9kdWN0cy8zMjEy/MjMvNDY0MTU4L3Bv/a2Vtb25zd29yZDI2/c2hpZWxkMDM1X182/MjU2OC4xNTgwNzY3/MzI5LmpwZz9jPTI",
                Price = 500.00m

            },
            new Product
            {
                Id = 3,
                Title = "Mew",
                Description = "Pokemon Promo Single Mew Card",
                ImageUrl = "https://imgs.search.brave.com/BUKX4p_Xu2peOCKs4Ehj_CeFHptCai02zhPu-Tj3TWM/rs:fit:1000:1200:1/g:ce/aHR0cHM6Ly9pNS53/YWxtYXJ0aW1hZ2Vz/LmNvbS9hc3IvY2M0/ZDQ3Y2QtMWIwMi00/Yzg4LWJhNWEtMjVj/MjBkMWVkNzdiXzEu/YzZlOGFkZTA4ODgw/YmMyOTVhY2E1Y2Q2/ZDc1N2Q0NzUuanBl/Zw",
                Price = 700.00m

            }
                );
        }
        public DbSet<Product> Products { get; set; }
    }
}
