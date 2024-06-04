using Microsoft.EntityFrameworkCore;

namespace CompleteDeveloperNetwork.Models
{
    public class FreelancerContext : DbContext
    {
        public FreelancerContext(DbContextOptions<FreelancerContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
