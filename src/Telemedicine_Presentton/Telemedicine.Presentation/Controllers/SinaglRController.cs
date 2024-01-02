using Microsoft.AspNetCore.Mvc;

namespace Telemedicine.Presentation.Controllers
{
    public class SignalRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
