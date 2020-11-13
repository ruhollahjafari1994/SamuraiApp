using Microsoft.EntityFrameworkCore;
using SamuraiAppDomain;
namespace SamuraiAppData
{
    public class SamuraiContext :DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }

        public DbSet<Quote> quotes { get; set; }
        public DbSet<Clan> clans { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //اضافه کردن کانکشن استرینگ 
        {
            optionsBuilder.UseSqlServer(
            "Data Source=GEEK;Initial Catalog=SamuraiAppData;Integrated Security=True");
                }
    }
}
