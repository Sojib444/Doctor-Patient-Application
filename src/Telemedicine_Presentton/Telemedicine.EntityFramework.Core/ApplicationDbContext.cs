using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.Doctors;
using Telemedicine.Domain.Patients;

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

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor {  Name = "Dr. Smith" , DesingNation = "MBBS", Email = "dr1@gmail.com", PasswordHash = "12345" },
                new Doctor {  Name = "Dr. Johnson", DesingNation = "MBBS", Email="dr2@gmail.com" ,PasswordHash ="12345" }
            );

            modelBuilder.Entity<Patient>().HasData(
                new Patient {  Name = "Patient A", Address = "Pabna", Email = "pr1@gmail.com", PasswordHash = "12345" },
                new Patient {  Name = "Patient B", Address = "Kushtia", Email = "pr2@gmail.com", PasswordHash = "12345" }
            );
        }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }
    }
}
