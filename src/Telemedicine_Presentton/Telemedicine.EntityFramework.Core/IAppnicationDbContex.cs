using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.Doctors;

namespace Telemedicine.EntityFramework.Core
{
    public interface IApplicationDbContex
    {
        DbSet<User> Doctors { get; }
    }
}
