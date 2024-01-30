using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.Repository;
using Telemedicine.Domain.Users;
using Telemedicine.EntityFramework.Core;

namespace Telemedicine.Application.Repository
{
    public class ChatRoomRepository : Repository<ChatRoom>, IChatRoomRepository
    {
        public ChatRoomRepository(IApplicationDbContex applicationDbContex) : base((DbContext)applicationDbContex)
        {
        }
    }
}
