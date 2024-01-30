using Telemedicine.Domain.Doctors;
using Telemedicine.Domain.Users;

namespace Telemedicine.Application.Services.ChatRooms
{
    public interface IChatRoomService
    {
        Task AddChatRoom(ChatRoom chatRoom);
        Task<ICollection<ChatRoom>> GetChatRooms();
        Task<ChatRoom> GetChatRoom(Guid id);
        Task DeleteChatRoom(Guid id);
        Task<ICollection<User>> GetChatUsers();
    }
}
