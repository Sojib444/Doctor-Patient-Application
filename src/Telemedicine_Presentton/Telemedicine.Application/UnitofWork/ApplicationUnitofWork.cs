using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.Repository;
using Telemedicine.Domain.UnitofWork;
using Telemedicine.EntityFramework.Core;

namespace Telemedicine.Application.UnitofWork
{
    public class ApplicationUnitofWork : UniOfWork, IApplicationUnitofWork
    {
        public IUserRepository DoctorRepository { get; set; }
        public ILoginRepository LoginRepository { get; set; }
        public IChatRoomRepository ChatRoomRepository { get; set; }

        public ApplicationUnitofWork(IUserRepository doctorRepository, ILoginRepository loginRepository,
            IApplicationDbContex applicationDbContex, IChatRoomRepository chatRoomRepository ) : base((DbContext)applicationDbContex)
        {
            DoctorRepository = doctorRepository;
            LoginRepository = loginRepository;
            ChatRoomRepository = chatRoomRepository;
        }
    }
}
