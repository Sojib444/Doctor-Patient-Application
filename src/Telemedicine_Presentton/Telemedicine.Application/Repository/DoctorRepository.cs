using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.Doctors;
using Telemedicine.Domain.Repository;
using Telemedicine.EntityFramework.Core;

namespace Telemedicine.Application.Repository
{
    public class DoctorRepository : Repository<User>, IDoctorRepository
    {
        public DoctorRepository(IApplicationDbContex applicationDbContex) : base((DbContext)applicationDbContex)
        {
            
        }
    }
}
