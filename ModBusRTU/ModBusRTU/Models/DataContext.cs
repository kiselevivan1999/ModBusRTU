using Microsoft.EntityFrameworkCore;

namespace ModBusRTU.Models
{
    public class DataContext : DbContext
    {

        public DataContext() 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Device> Devices { get; set; }
    }
}
