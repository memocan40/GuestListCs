using GuestList.Models;
using Microsoft.EntityFrameworkCore;

namespace GuestList.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Guest> Guests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Connectionstring.Get());
        }
    }
}
