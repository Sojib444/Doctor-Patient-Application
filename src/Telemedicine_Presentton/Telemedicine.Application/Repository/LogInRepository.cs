using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.AddLoginUser;
using Telemedicine.Domain.Repository;
using Telemedicine.EntityFramework.Core;

namespace Telemedicine.Application.Repository
{
    public class LogInRepository : Repository<LoginUser>, ILoginRepository
    {
        public LogInRepository(IApplicationDbContex applicationDbContex) : base((DbContext)applicationDbContex)
        {
        }
    }
}
