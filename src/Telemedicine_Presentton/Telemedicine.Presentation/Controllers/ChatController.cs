using Microsoft.AspNetCore.Mvc;

namespace Telemedicine.Presentation.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
