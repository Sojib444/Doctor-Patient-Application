using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Telemedicine.Application.Services.DoctorServices;

namespace Telemedicine.Presentation.Controllers
{
    public class MessageController : Controller
    {
        private IUserServices _userServices { get; }

        public MessageController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<object> GetChatUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var users = await _userServices.AllUsers();

            if (User == null)
            {
                return NotFound();
            }

            return users.Where(u => u.Email != userId).Select(u => new { u.Email, u.Name });
        }
    }
}
