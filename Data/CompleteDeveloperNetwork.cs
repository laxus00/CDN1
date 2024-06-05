using Microsoft.EntityFrameworkCore;
using CompleteDeveloperNetwork.Models;

namespace CompleteDeveloperNetwork.Data
{
    public class CompleteDeveloperNetworkContext : DbContext
    {
        public CompleteDeveloperNetworkContext(DbContextOptions<CompleteDeveloperNetworkContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
