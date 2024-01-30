using Telemedicine.Domain.Doctors;
using Telemedicine.Domain.UnitofWork;
using Telemedicine.Domain.Users;

namespace Telemedicine.Application.Services.ChatRooms
{
    public class ChatRoomService : IChatRoomService
    {
        private readonly IApplicationUnitofWork _unitofWork;

        public ChatRoomService(IApplicationUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }
        public async Task AddChatRoom(ChatRoom chatRoom)
        {
           await _unitofWork.ChatRoomRepository.CreatAsync(chatRoom);
           await _unitofWork.SaveChangeAsync();
           _unitofWork.Dispose();
        }

        public async Task DeleteChatRoom(Guid id)
        {
            await _unitofWork.ChatRoomRepository.DeleteAsync(id);
            await _unitofWork.SaveChangeAsync();
            _unitofWork.Dispose();
        }

        public async Task<ChatRoom> GetChatRoom(Guid id)
        {
            return await _unitofWork.ChatRoomRepository.GetAsync(id);
        }

        public Task<ICollection<ChatRoom>> GetChatRooms()
        {
            return _unitofWork.ChatRoomRepository.GetListAsync();
        }

        public async Task<ICollection<User>> GetChatUsers()
        {
           return await _unitofWork.DoctorRepository.GetListAsync();
        }
    }
}
