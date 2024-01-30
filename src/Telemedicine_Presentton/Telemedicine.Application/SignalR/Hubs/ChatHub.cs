using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;
using Telemedicine.Application.Services.DoctorServices;

namespace Telemedicine.Application.SignalR.Hubs
{
    public class ChatHub : Hub
    {
        private readonly UserServcies _userServcies;

        public ChatHub(UserServcies userServcies)
        {
            _userServcies = userServcies;
        }
        public async Task SendAddRoomMessage(int maxRoom, int roomId, string roomName)
        {
            var UserId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = _userServcies.GetUser(UserId).Result.Name;

            await Clients.All.SendAsync("ReceiveAddRoomMessage", maxRoom, roomId, roomName, UserId, userName);
        }

        public async Task SendDeleteRoomMessage(int deleted, int selected, string roomName)
        {
            var UserId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = _userServcies.GetUser(UserId).Result.Name;

            await Clients.All.SendAsync("ReceiveDeleteRoomMessage", deleted, selected, roomName, userName);
        }

        public async Task SendPublicMessage(int roomId, string message, string roomName)
        {
            var UserId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = _userServcies.GetUser(UserId).Result.Name;

            await Clients.All.SendAsync("ReceivePublicMessage", roomId, UserId, userName, message, roomName);
        }

        public async Task SendPrivateMessage(string receiverId, string message, string receiverName)
        {
            var senderId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var senderName = _userServcies.GetUser(senderId).Result.Name;

            var users = new string[] { senderId, receiverId };

            await Clients.Users(users)
                .SendAsync("ReceivePrivateMessage", senderId, senderName, receiverId, message, Guid.NewGuid(), receiverName);
        }

        public async Task SendOpenPrivateChat(string receiverId)
        {
            var username = Context.User.FindFirstValue(ClaimTypes.Name);
            var userId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier);

            await Clients.User(receiverId).SendAsync("ReceiveOpenPrivateChat", userId, username);
        }

        public async Task SendDeletePrivateChat(string chartId)
        {
            await Clients.All.SendAsync("ReceiveDeletePrivateChat", chartId);
        }
    }
}
