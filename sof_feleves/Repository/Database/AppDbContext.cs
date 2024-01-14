using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sof_feleves.Models;
using Syncfusion.EJ2.Diagrams;
using Syncfusion.EJ2.Navigations;
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
                new Service { ID = "yoga_class1", HostID = "yoga_host1", Name = "Yoga class", Description = "Yoga for your body and mind at the yoga studio with your yoga host", Location = "Yoga Studio in Budapest" },
                new Service { ID = "dance_class1", HostID = "dance_host1", Name = "Dance class", Description = "Contemporary dance class for creative minds", Location = "Dance Studio in Paris" },
                new Service { ID = "nail_salon1", HostID = "nail_host1", Name = "Nail salon", Description = "Luxury Nail salon located in the heart of London<3", Location = "London Nail Salon" },
                new Service { ID = "chiropractor1", HostID = "chiropractor_host1", Name = "Chiropractor", Description = "Certified chiropractor - based in New York", Location = "New York" }
                );

            builder.Entity<Appointment>().HasData(
                new Appointment { ID = "apt1", Date = DateTime.SpecifyKind(new DateTime(2025, 06, 28, 10, 0, 0), DateTimeKind.Utc), MaxApplicants = 10, ServiceID = "yoga_class1" },
                new Appointment { ID = "apt2", Date = DateTime.SpecifyKind(new DateTime(2025, 06, 28, 12, 0, 0), DateTimeKind.Utc), MaxApplicants = 10, ServiceID = "yoga_class1" },
                new Appointment { ID = "apt3", Date = DateTime.SpecifyKind(new DateTime(2025, 05, 05, 13, 30, 0), DateTimeKind.Utc), MaxApplicants = 1, ServiceID = "nail_salon1" },
                new Appointment { ID = "apt4", Date = DateTime.SpecifyKind(new DateTime(2025, 07, 28, 19, 0, 0), DateTimeKind.Utc), MaxApplicants = 25, ServiceID = "dance_class1" },
                new Appointment { ID = "apt5", Date = DateTime.SpecifyKind(new DateTime(2025, 07, 29, 19, 0, 0), DateTimeKind.Utc), MaxApplicants = 25, ServiceID = "dance_class1" },
                new Appointment { ID = "apt6", Date = DateTime.SpecifyKind(new DateTime(2025, 08, 28, 19, 0, 0), DateTimeKind.Utc), MaxApplicants = 25, ServiceID = "dance_class1" }
                );

            builder.Entity<Post>().HasData(
               new Post { ID = "post1", Text = "Yoga for your body and mind at the yoga studio with your yoga host", ServiceID = "yoga_class1", Title = "Yoga classes" },
               new Post { ID = "post2", Text = "Unfortunately I have to cancel today's dance class because I have COVID. :( See you guys next week!", ServiceID = "dance_class1", Title = "TODAY'S CLASS IS CANCELED!" },
               new Post { ID = "post3", Text = "Hello guys, someone left their Gucci bag at my studio. Please come pick it up!", ServiceID = "nail_salon1", Title = "Gucci bag left at studio!!" },
               new Post { ID = "post4", Text = "Dear Guests, please make sure you don't make a mess after yourself when using the toilet at my office. I had to clean for hours after someone pooped there...", ServiceID = "chiropractor1", Title = "Someone clogged the toilet at my office..." }
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
