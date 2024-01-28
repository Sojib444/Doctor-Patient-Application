using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Telemedicine.Application.Dtos;
using Telemedicine.Application.Services.DoctorServices;
using Telemedicine.Application.Services.LoginUsers;
using Telemedicine.Application.SignalR.Hubs;

namespace Telemedicine.Presentation.Controllers
{
    public class UserController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IUserServices userServices;
        private readonly ILoginUserService loginUserService;

        public UserController(SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager,
            IUserServices userServices,
            ILoginUserService loginUserService)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.userServices = userServices;
            this.loginUserService = loginUserService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var allUsers = await userServices.AllUsers();
            var allLoginUsers = HubConnections.OnlineUser();

            List<UserDto> users = new List<UserDto>();

            foreach (var user in allLoginUsers)
            {
                foreach (var item in allUsers)
                {
                    if (item.Id.ToString() == user && item.AccountType == 1)
                    {
                        users.Add(item);
                        break;
                    }
                }
            }

            return View(users);
        }
    }
}