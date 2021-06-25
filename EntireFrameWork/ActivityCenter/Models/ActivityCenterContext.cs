using Microsoft.EntityFrameworkCore;


namespace ActivityCenter.Models
{
    public class ActivityCenterContext : DbContext
    {
        public ActivityCenterContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Activit> Activits { get; set; }
        public DbSet<Join> Joins { get; set; }
    }
}