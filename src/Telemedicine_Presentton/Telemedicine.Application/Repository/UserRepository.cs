using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.Doctors;
using Telemedicine.Domain.Repository;
using Telemedicine.EntityFramework.Core;

namespace Telemedicine.Application.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IApplicationDbContex applicationDbContex) : base((DbContext)applicationDbContex)
        {
            
        }
    }
}
