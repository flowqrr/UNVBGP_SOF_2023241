using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sof_feleves.Models;
using System.Reflection.Emit;

namespace sof_feleves.Repository
{
    public class AppDbContext : IdentityDbContext<SiteUser>
    {
        public DbSet<SiteUser> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Host", NormalizedName = "HOST" },
                new IdentityRole { Id = "0", Name = "Guest", NormalizedName = "GUEST" }
                );


            var hasher = new PasswordHasher<IdentityUser>();
            builder.Entity<SiteUser>().HasData(
                new SiteUser { Id = "yoga_host1", Email = "yoga@yoga.yoga", FirstName = "Yoga", SurName = "Master", NormalizedUserName = "YOGA", PasswordHash = hasher.HashPassword(null, "yoga") },
                new SiteUser { Id = "dance_host1", Email = "dance@dance.dance", FirstName = "Dance", SurName = "Master", NormalizedUserName = "DANCE", PasswordHash = hasher.HashPassword(null, "dance") },
                new SiteUser { Id = "nail_host1", Email = "nail@nail.nail", FirstName = "Nail", SurName = "Master", NormalizedUserName = "NAIL", PasswordHash = hasher.HashPassword(null, "nail") },
                new SiteUser { Id = "chiropractor_host1", Email = "chiropractor@chiropractor.chiropractor", FirstName = "Chiropractor", SurName = "Master", NormalizedUserName = "CHIROPRACTOR", PasswordHash = hasher.HashPassword(null, "chiropractor") }
                );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = "1", UserId = "yoga_host1" },
                new IdentityUserRole<string> { RoleId = "1", UserId = "dance_host1" },
                new IdentityUserRole<string> { RoleId = "1", UserId = "nail_host1" },
                new IdentityUserRole<string> { RoleId = "1", UserId = "chiropractor_host1" }
            );


            builder.Entity<Service>().HasData(
                new Service { ID = "yoga_class1", HostID = "yoga_host1", Name = "Yoga class" },
                new Service { ID = "dance_class1", HostID = "dance_host1", Name = "Dance class" },
                new Service { ID = "nail_salon1", HostID = "nail_host1", Name = "Nail salon" },
                new Service { ID = "chiropractor1", HostID = "chiropractor_host1", Name = "Chiropractor" }
                );

            builder.Entity<Appointment>()
                .Property(a => a.Date)
                .HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

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

            builder.Entity<Service>()
                .HasMany(service => service.Posts)
                .WithOne(post => post.Service)
                .HasForeignKey(post => post.ServiceID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<SiteUser>()
                .HasMany(user => user.Appointments)
                .WithMany(appointment => appointment.Applicants);

            base.OnModelCreating(builder);
        }
    }
}
