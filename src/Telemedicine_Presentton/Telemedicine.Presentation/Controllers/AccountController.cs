﻿using Autofac;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Telemedicine.Application.Services.DoctorServices;
using Telemedicine.Application.Services.LoginUsers;
using Telemedicine.Domain.AddLoginUser;
using Telemedicine.Domain.Doctors;
using Telemedicine.Presentation.Models;

namespace Telemedicine.Presentation.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILoginUserService _loginUserService;

        public IDoctorServices _doctorServices { get; set; }
        public UserManager<IdentityUser> _userManager { get; }
        public ILifetimeScope _scope { get; }

        public AccountController(IDoctorServices doctorServices,
            IMapper mapper,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILoginUserService loginUserService)
        {
            _doctorServices = doctorServices;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _loginUserService = loginUserService;
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
                    AccoutType = model.AccountType,
                    Name = model.Name

                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    LoginUser loginUser = new LoginUser();

                    loginUser.LoginTime = DateTime.Now;
                    loginUser.UserName = user.UserName;

                    await _loginUserService.AddAsync(loginUser);

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
                    LoginUser loginUser = new LoginUser();

                    loginUser.LoginTime = DateTime.Now;
                    loginUser.UserName = user.Email;

                    await _loginUserService.AddAsync(loginUser);

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

                await _loginUserService.RemoveAsync(currentLoggedInUser.Email);
            }

            return RedirectToAction("Registration","Account");
        }

    }
}
