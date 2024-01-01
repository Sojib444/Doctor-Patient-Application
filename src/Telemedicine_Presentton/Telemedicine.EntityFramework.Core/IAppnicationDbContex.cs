using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.Doctors;
using Telemedicine.Domain.Patients;

namespace Telemedicine.EntityFramework.Core
{
    public interface IApplicationDbContex 
    {
        DbSet<Doctor> Doctors { get; }
        DbSet<Patient> Patients { get; }
    }
}
