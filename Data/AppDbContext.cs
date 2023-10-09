using GuestList.Models;
using Microsoft.EntityFrameworkCore;

namespace GuestList.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(Connectionstring.Get());
            }
        }
    }
}
