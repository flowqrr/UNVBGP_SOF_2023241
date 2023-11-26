using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using sof_feleves.Logic.Interfaces;
using sof_feleves.Models;
using System.Diagnostics;

namespace sof_feleves.Controllers
{
    public class GuestController : Controller
    {
        private readonly ILogger<GuestController> _logger;
        private readonly UserManager<SiteUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IServiceLogic _serviceLogic;

        public GuestController(
            ILogger<GuestController> logger,
            UserManager<SiteUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IServiceLogic serviceLogic)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _serviceLogic = serviceLogic;
        }

        public IActionResult ServiceView(string id)
        {
            Service service = _serviceLogic.Read(id);
            return View(service);
        }

        public IActionResult ApplyForTimeSlot()
        {
            return View();
        }

        public IActionResult CancelTimeSlotApplication()
        {
            return View();
        }

        public IActionResult BuyPass()
        {
            return View();
        }

        public IActionResult BuyTicket()
        {
            return View();
        }
    }
}
