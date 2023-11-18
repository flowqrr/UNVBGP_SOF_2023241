using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sof_feleves.Models;

namespace sof_feleves.Repository
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Service> Services { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Service>().HasData(
                new Service { ID = "yoga_class1", HostID = "yoga_host1", Name = "Yoga class" },
                new Service { ID = "dance_class1", HostID = "dance_host1", Name = "Dance class" },
                new Service { ID = "nail_salon1", HostID = "nail_host1", Name = "Nail salon" },
                new Service { ID = "chiropractor1", HostID = "chiropractor_host1", Name = "Chiropractor" }
                );

            base.OnModelCreating(builder);
        }
    }
}
