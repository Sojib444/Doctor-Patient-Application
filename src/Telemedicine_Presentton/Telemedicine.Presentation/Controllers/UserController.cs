using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalRSample.Data;
using SignalRSample.Hubs;
using SignalRSample.Models;

namespace Telemedicine.Presentation.Controllers
{
    public class UserController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly ApplicationDbContext dbContext;

        public UserController(SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager,ApplicationDbContext dbContext)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var allUsers = dbContext.User.ToList() ;
            var allLoginUsers = HubConnections.OnlineUsers();

            List<User> users = new List<User>();

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