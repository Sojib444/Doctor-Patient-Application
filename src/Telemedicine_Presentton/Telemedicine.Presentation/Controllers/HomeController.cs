using Microsoft.AspNetCore.Mvc;
using SignalRSample.Data;
using SignalRSample.Models.ViewModel;
using System.Security.Claims;

namespace SignalRSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();

        }
        public IActionResult AdvancedChat()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ChatVM chatVm = new()
            {
                Rooms = _context.ChatRoom.ToList(),
                MaxRoomAllowed = 4,
                UserId = userId,
            };
            return View(chatVm);
        }

    }
}