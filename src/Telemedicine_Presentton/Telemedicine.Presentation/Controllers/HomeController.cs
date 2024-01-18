using Autofac;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Telemedicine.Application.Dtos;
using Telemedicine.Application.Services.DoctorServices;
using Telemedicine.Presentation.Models;

namespace Telemedicine.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        public IUserServices _doctorServices { get; set; }
        public ILifetimeScope _scope { get; }

        public HomeController(ILogger<HomeController> logger, IUserServices doctorServices, IMapper mapper)
        {
            _logger = logger;
            _doctorServices = doctorServices;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
