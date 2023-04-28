using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace home_work_49.Models
{
    public class ZooContext :DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Order> Orders { get; set; }
        public ZooContext(DbContextOptions<ZooContext> options) : base(options) { }
    }
}
