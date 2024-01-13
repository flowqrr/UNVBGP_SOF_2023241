using Humanizer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using sof_feleves.Logic;
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
        private readonly IAppointmentLogic _appointmentLogic;

        public GuestController(
            ILogger<GuestController> logger,
            UserManager<SiteUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IServiceLogic serviceLogic,
            IAppointmentLogic appointmentLogic)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _serviceLogic = serviceLogic;
            _appointmentLogic = appointmentLogic;
        }

        public async Task<IActionResult> Dashboard()
        {
            List<Service> services = _serviceLogic.ReadAll().ToList();
            return View(services);
        }

        public IActionResult ServiceView(string id)
        {
            Service service = _serviceLogic.Read(id);
            return View(service);
        }

        public IActionResult GuestAppointmentsView(List<Appointment> appointments)
        {
            return View(appointments);
        }

        [HttpPost]
        public async Task<IActionResult> ApplyForAppointment(string appointmentId)
        {
            Appointment appointment = _appointmentLogic.Read(appointmentId);
            var user = await _userManager.GetUserAsync(User);

            try
            {
                _appointmentLogic.ApplyForAppointment(appointment, user);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
            catch (AppointmentFullException e)
            {
                return Ok(e.Message);
            }

            return View("GuestAppointmentsView", user.Appointments);
        }

        public IActionResult CancelAppointmentApplication()
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
