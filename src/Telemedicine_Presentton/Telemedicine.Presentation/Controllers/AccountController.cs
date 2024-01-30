using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalRSample.Data;
using SignalRSample.Hubs;
using SignalRSample.Models;
using System.Security.Claims;

namespace Telemedicine.Presentation.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserManager<IdentityUser> _userManager { get; }
        public ApplicationDbContext ApplicationDbContext { get; }

        public AccountController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager, ApplicationDbContext applicationDbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            ApplicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Registration()
        {
            // ViewBag.SecondTimes = ViewBag.Message as string;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(UserRegistration model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Email = model.Email,
                    AccountType = model.AccountType,
                    Name = model.Name

                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddClaimAsync(user, new Claim("Name", model.Name));

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("index", "Home");
                }

            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserLogin user)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(user.Email,user.Password,true,false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            //ViewBag.Message = "Incorrect Email or Password";

            return RedirectToAction("Registration", "Account");
        }

        public async Task<IActionResult> Logout()
        {
            var currentLoggedInUser = await _userManager.GetUserAsync(User);

            if (currentLoggedInUser != null)
            {
                await _signInManager.SignOutAsync();

                //await _loginUserService.RemoveAsync(currentLoggedInUser.Email);

                HubConnections.Users.Remove(User.FindFirstValue(ClaimTypes.NameIdentifier));
            }

            return RedirectToAction("Registration", "Account");
        }

    }
}
