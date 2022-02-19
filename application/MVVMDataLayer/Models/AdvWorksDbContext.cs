using Microsoft.EntityFrameworkCore;
using MVVMEntityLayer;

namespace MVVMDataLayer
{
    public partial class AdvWorksDbContext : DbContext
    {
        public AdvWorksDbContext(DbContextOptions<AdvWorksDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
    }
}