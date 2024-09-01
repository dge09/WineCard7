using Microsoft.EntityFrameworkCore;
using WineCard7.DB.Entitys;

namespace WineCard7.DB
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WineCard7;Integrated Security=True;");
        }

        public DbSet<WGrapeVariety> GrapeVarietys { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<WOriginCountry> OriginCountrys { get; set; }
        public DbSet<WOriginFederalState> OriginFederalStates { get; set; }
        public DbSet<WPrice> Prices { get; set; }
        public DbSet<WType> Types { get; set; }
        public DbSet<WWinery> Winerys { get; set; }
        public DbSet<WYear> Years { get; set; }
    }
}
