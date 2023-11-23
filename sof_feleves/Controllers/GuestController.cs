using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using sof_feleves.Models;
using System.Diagnostics;

namespace sof_feleves.Controllers
{
    public class GuestController : Controller
    {
        private readonly ILogger<GuestController> _logger;
        private readonly UserManager<SiteUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public GuestController(ILogger<GuestController> logger, UserManager<SiteUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult VisitHost()
        {
            return View();
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
