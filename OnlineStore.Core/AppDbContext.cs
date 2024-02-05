using Microsoft.EntityFrameworkCore;
using OnlineStore.Core.Models;

namespace OnlineStore.Core
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Test> Tests { get; set; }
    }
}
