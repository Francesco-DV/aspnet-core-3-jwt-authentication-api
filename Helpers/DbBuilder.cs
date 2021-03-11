using WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Helpers
{
    public class AuthContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseNpgsql("Host=localhost;Database=SPS;Username=postgres;Password=32769!");
    }
}