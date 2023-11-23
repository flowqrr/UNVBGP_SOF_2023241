using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using sof_feleves.Logic.Interfaces;
using sof_feleves.Models;
using sof_feleves.Repository;
using System.Diagnostics;

namespace sof_feleves.Controllers
{
    [Authorize(Roles = "Host")]
    public class HostController : Controller
    {
        private readonly ILogger<HostController> _logger;
        private readonly UserManager<SiteUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IServiceLogic _serviceLogic;

        public HostController(
            ILogger<HostController> logger,
            UserManager<SiteUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IServiceLogic serviceLogic)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _serviceLogic = serviceLogic;
        }

        public async Task<IActionResult> Dashboard()
        {
            var user = await _userManager.GetUserAsync(User);
            List<Service> services = user.HostedServices?.ToList() ?? new List<Service>();
            return View(services);
        }

        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddService(Service service)
        {
            var user = await _userManager.GetUserAsync(User);
            service.HostID = user.Id;
            _serviceLogic.Create(service);
            return RedirectToAction(nameof(Dashboard));
        }

        public IActionResult WriteMessage()
        {
            return View();
        }

        public IActionResult AddTimeSlot()
        {
            return View();
        }

        public IActionResult EditTimeSlot()
        {
            return View();
        }

        public IActionResult AddPass()
        {
            return View();
        }

        public IActionResult EditPass()
        {
            return View();
        }

        public IActionResult DeletePass()
        {
            return View();
        }

        public IActionResult DeleteTimeSlot()
        {
            return View();
        }
    }
}
