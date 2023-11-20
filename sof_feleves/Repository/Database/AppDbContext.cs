using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sof_feleves.Models;

namespace sof_feleves.Repository
{
    public class AppDbContext : IdentityDbContext<SiteUser>
    {
        public DbSet<SiteUser> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SiteUser>().HasData(
                new SiteUser { Id = "yoga_host1", Email = "yoga@yoga.yoga", FirstName = "Yoga", SurName = "Master", NormalizedUserName = "YOGA" },
                new SiteUser { Id = "dance_host1", Email = "dance@dance.dance", FirstName = "Dance", SurName = "Master", NormalizedUserName = "DANCE" },
                new SiteUser { Id = "nail_host1", Email = "nail@nail.nail", FirstName = "Nail", SurName = "Master", NormalizedUserName = "NAIL" },
                new SiteUser { Id = "chiropractor_host1", Email = "chiropractor@chiropractor.chiropractor", FirstName = "Chiropractor", SurName = "Master", NormalizedUserName = "CHIROPRACTOR" }
                );

            builder.Entity<Service>().HasData(
                new Service { ID = "yoga_class1", HostID = "yoga_host1", Name = "Yoga class" },
                new Service { ID = "dance_class1", HostID = "dance_host1", Name = "Dance class" },
                new Service { ID = "nail_salon1", HostID = "nail_host1", Name = "Nail salon" },
                new Service { ID = "chiropractor1", HostID = "chiropractor_host1", Name = "Chiropractor" }
                );

            builder.Entity<Service>()
                .HasOne(service => service.Host)
                .WithMany(host => host.HostedServices)
                .HasForeignKey(service => service.HostID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Service>()
                .HasMany(service => service.Appointments)
                .WithOne(appointment => appointment.Service)
                .HasForeignKey(appointment => appointment.ServiceID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<SiteUser>()
                .HasMany(user => user.Appointments)
                .WithMany(appointment => appointment.Applicants);

            base.OnModelCreating(builder);
        }
    }
}
