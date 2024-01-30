using Telemedicine.Domain.Repository;

namespace Telemedicine.Domain.UnitofWork
{
    public interface IApplicationUnitofWork : IUnitofWork
    {
        IUserRepository DoctorRepository { get; }
        ILoginRepository LoginRepository { get; }
        IChatRoomRepository ChatRoomRepository { get; }
    }
}
