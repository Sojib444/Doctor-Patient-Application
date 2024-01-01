using Telemedicine.Domain.Repository;

namespace Telemedicine.Domain.UnitofWork
{
    public interface IApplicationUnitofWork : IUnitofWork
    {
        IPatientRepository PatientRepository { get; }
        IDoctorRepository DoctorRepository { get; }
    }
}
