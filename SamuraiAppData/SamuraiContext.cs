using Microsoft.EntityFrameworkCore;
using SamuraiAppDomain;
namespace SamuraiAppData
{
    public class SamuraiContext :DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> quotes { get; set; }
        public DbSet<Clan> clans { get; set; }
    }
}
