using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.Patients;
using Telemedicine.Domain.Repository;
using Telemedicine.EntityFramework.Core;

namespace Telemedicine.Application.Repository
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        public PatientRepository(IApplicationDbContex applicationDbContex) : base((DbContext)applicationDbContex)
        {
            
        }
    }
}
