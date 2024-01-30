using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.AddLoginUser;
using Telemedicine.Domain.Doctors;
using Telemedicine.Domain.Users;

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
                new User { Name = "Dr. Smith", Email = "dr1@gmail.com", PasswordHash = "12345", AccountType = 1, },
                new User { Name = "Dr. Johnson", Email = "dr2@gmail.com", PasswordHash = "12345", AccountType = 2 }
            );

            modelBuilder.Entity<ChatRoom>().HasData(
                new ChatRoom {Id = 1, Name="Sojib" },
                new ChatRoom { Id = 2, Name = "Abir" }
            );
        }

        public DbSet<User> Doctors { get; set; }
        public DbSet<LoginUser> LoginUsers { get; set; }
        public DbSet<ChatRoom> ChatRooms { get; set; }
    }
}
