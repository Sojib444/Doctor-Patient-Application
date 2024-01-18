using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.Repository;
using Telemedicine.Domain.UnitofWork;
using Telemedicine.EntityFramework.Core;

namespace Telemedicine.Application.UnitofWork
{
    public class ApplicationUnitofWork : UniOfWork, IApplicationUnitofWork
    {
        public IDoctorRepository DoctorRepository { get; set; }
        public ILoginRepository LoginRepository { get; set; }

        public ApplicationUnitofWork(IDoctorRepository doctorRepository, ILoginRepository loginRepository,
            IApplicationDbContex applicationDbContex) : base((DbContext)applicationDbContex)
        {
            this.DoctorRepository = doctorRepository;
            LoginRepository = loginRepository;
        }
    }
}
