using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Telemedicine.Presentation.Controllers
{
    public class DoctorController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

        public DoctorController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        public async Task<IActionResult> IndexAsync()
        {
            return View();
        }
    }
}
