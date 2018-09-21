using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using iotWork.Models.Mapping;

namespace iotWork.Models
{
    public partial class remoteWorkContext : DbContext
    {
        static remoteWorkContext()
        {
            Database.SetInitializer<remoteWorkContext>(null);
        }

        public remoteWorkContext()
            : base("Name=remoteWorkContext")
        {
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DeviceMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TypeMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
