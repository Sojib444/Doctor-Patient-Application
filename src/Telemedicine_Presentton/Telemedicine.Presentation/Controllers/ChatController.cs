using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Telemedicine.Application.Services.ChatRooms;
using Telemedicine.Presentation.Models.ViewModel;

namespace Telemedicine.Presentation.Controllers
{
    public class ChatController : Controller
    {
        private readonly IChatRoomService chatRoomService;

        public ChatController(IChatRoomService chatRoomService)
        {
            this.chatRoomService = chatRoomService;
        }
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ChatVM chatVm = new()
            {
                Rooms = await chatRoomService.GetChatRooms(),
                MaxRoomAllowed = 4,
                UserId = userId,
            };

            return View(chatVm);
        }
    }
}
