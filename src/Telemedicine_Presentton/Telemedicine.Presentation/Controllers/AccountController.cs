using Autofac;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Telemedicine.Application.Services.DoctorServices;
using Telemedicine.Domain.Doctors;
using Telemedicine.Presentation.Models;

namespace Telemedicine.Presentation.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly SignInManager<IdentityUser> _signInManager;
        public IDoctorServices _doctorServices { get; set; }
        public UserManager<IdentityUser> _userManager { get; }
        public ILifetimeScope _scope { get; }

        public AccountController(IDoctorServices doctorServices,
            IMapper mapper,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _doctorServices = doctorServices;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public async Task<IActionResult> Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(UserRegistration model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Email = model.Email,
                    AccoutType = model.AccountType,
                    Name = model.Name

                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
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
            return View(user);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Registration","Account");
        }

    }
}
