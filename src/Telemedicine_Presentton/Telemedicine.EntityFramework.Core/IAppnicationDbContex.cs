using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.AddLoginUser;
using Telemedicine.Domain.Doctors;
using Telemedicine.Domain.Users;

namespace Telemedicine.EntityFramework.Core
{
    public interface IApplicationDbContex
    {
        DbSet<User> Doctors { get; }
        DbSet<LoginUser> LoginUsers { get; }
        DbSet<ChatRoom> ChatRooms { get; }
    }
}
