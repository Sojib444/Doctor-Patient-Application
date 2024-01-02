using Telemedicine.Domain.Repository;

namespace Telemedicine.Domain.UnitofWork
{
    public interface IApplicationUnitofWork : IUnitofWork
    {
        IDoctorRepository DoctorRepository { get; }
    }
}
