using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using sof_feleves.Logic;
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
        private readonly IPostLogic _postLogic;
        private readonly IApointmentLogic _appointmentLogic;

        public HostController(
            ILogger<HostController> logger,
            UserManager<SiteUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IServiceLogic serviceLogic,
            IPostLogic postLogic,
            IApointmentLogic apointmentLogic
            )
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _serviceLogic = serviceLogic;
            _postLogic = postLogic;
            _appointmentLogic = apointmentLogic;
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

            try
            {
                _serviceLogic.Create(service);
            }
            catch (ArgumentException ex)
            {
                return View(service);
            }

            return RedirectToAction(nameof(Dashboard));
        }

        [HttpGet]
        public IActionResult DeleteService(string id)
        {
            _serviceLogic.Delete(id);
            return RedirectToAction(nameof(Dashboard));
        }

        public IActionResult ServiceEdit(string id)
        {
            Service service = _serviceLogic.Read(id);
            return View(service);
        }

        [HttpPost]
        public IActionResult UpdateServiceName(string id, string newName)
        {
            Service service = _serviceLogic.Read(id);
            service.Name = newName;
            _serviceLogic.Update(service);
            return Ok();
        }

        [HttpPost]
        public IActionResult UpdateServiceDescription(string id, string newDescription)
        {
            Service service = _serviceLogic.Read(id);
            service.Description = newDescription;
            _serviceLogic.Update(service);
            return Ok();
        }

        [HttpGet]
        public IActionResult AddPost(string serviceId)
        {
            Post post = new Post();
            post.ServiceID = serviceId;
            return View(post);
        }

        [HttpPost]
        public async Task<IActionResult> AddPost(Post post)
        {
            try
            {
                _postLogic.Create(post);
            }
            catch (ArgumentException ex)
            {
                return View(post);
            }
            return RedirectToAction("ServiceEdit", new { id = post.ServiceID });
        }


        [HttpPost]
        public async Task<IActionResult> AddAppointment(Appointment appointment)
        {

                try
                {
                    var asd = appointment.ServiceID;
                    _appointmentLogic.Create(appointment);

                return RedirectToAction("ServiceEdit", new { id = appointment.ServiceID });
            }
                catch (ArgumentException ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }

            return View(appointment);
        }

        [HttpPost]
        public async Task<IActionResult> EditAppointment(Appointment appointment)
        {
                try
                {
                    _appointmentLogic.Update(appointment);

                return RedirectToAction("ServiceEdit", new { id = appointment.ServiceID });
            }
                catch (Exception ex) // Consider more specific exception handling
                {
                    ModelState.AddModelError("", "There was an error updating the appointment.");
                }
            return View(appointment);
        }

        public IActionResult WriteMessage()
        {
            return View();
        }
        public IActionResult AddAppointment(string serviceId)
        {
            Appointment appointment = new Appointment();
            appointment.ServiceID = serviceId;
            return View(appointment);
        }
        public IActionResult EditAppointment(string id)
        {
            var appointment = _appointmentLogic.Read(id);
            if (appointment == null)
            {
                return NotFound();
            }
            return View(appointment);
        }
        [HttpGet]
        public IActionResult DeleteAppointment(string id)
        {
            Appointment appointment = _appointmentLogic.Read(id);
            _appointmentLogic.Delete(id);
            return RedirectToAction("ServiceEdit", new { id = appointment.ServiceID });
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
