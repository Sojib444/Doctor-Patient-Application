using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.Doctors;

namespace Telemedicine.EntityFramework.Core
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>, IApplicationDbContex
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User { Name = "Dr. Smith", Email = "dr1@gmail.com", PasswordHash = "12345", AccoutType = 1, },
                new User { Name = "Dr. Johnson", Email = "dr2@gmail.com", PasswordHash = "12345", AccoutType = 2 }
            );
        }

        public DbSet<User> Doctors { get; set; }

    }
}
