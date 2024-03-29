﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json.Linq;
using sof_feleves.Logic;
using sof_feleves.Logic.Interfaces;
using sof_feleves.Models;
using sof_feleves.Other;
using sof_feleves.Repository;
using System.Diagnostics;

namespace sof_feleves.Controllers
{
    [Authorize(Roles = "Host")]
    [EnableCors("CorsPolicy")]
    public class HostController : Controller
    {
        private readonly ILogger<HostController> _logger;
        private readonly UserManager<SiteUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IServiceLogic _serviceLogic;
        private readonly IPostLogic _postLogic;
        private readonly IAppointmentLogic _appointmentLogic;
        private readonly IHubContext<SignalRHub> _hub;

        public HostController(
            ILogger<HostController> logger,
            UserManager<SiteUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IServiceLogic serviceLogic,
            IPostLogic postLogic,
            IAppointmentLogic apointmentLogic,
            IHubContext<SignalRHub> hub
            )
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _serviceLogic = serviceLogic;
            _postLogic = postLogic;
            _appointmentLogic = apointmentLogic;
            _hub = hub;
        }

        public async Task<IActionResult> HostDashboard()
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
                await _hub.Clients.All.SendAsync("ServiceCountChanged", new { ID = service.ID, Name = service.Name, Location = service.Location, HostName = $"{service.Host.FirstName} {service.Host.SurName}" });
            }
            catch (ArgumentException ex)
            {
                return View(service);
            }

            return RedirectToAction(nameof(HostDashboard));
        }

        [HttpGet]
        public async Task<IActionResult> DeleteService(string id)
        {
            _serviceLogic.Delete(id);
            await _hub.Clients.All.SendAsync("ServiceCountChanged", id );
            return RedirectToAction(nameof(HostDashboard));
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

        [HttpPost]
        public IActionResult UpdateServiceLocation(string id, string newLocation)
        {
            Service service = _serviceLogic.Read(id);
            service.Location = newLocation;
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
            if (post.Image != null)
            {
                using (var stream = post.Image.OpenReadStream())
                {
                    byte[] buffer = new byte[post.Image.Length];
                    stream.Read(buffer, 0, (int)post.Image.Length);
                    string filename = post.ID + "." + post.Image.FileName.Split('.')[1];
                    post.ImageData = buffer;
                    post.ImageContentType = post.Image.ContentType;
                }
            }

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
                _appointmentLogic.Create(appointment);

                return RedirectToAction("ServiceEdit", new { id = appointment.ServiceID });
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError("", ex.Message);
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

        [HttpGet]
        public IActionResult EditAppointment(string id)
        {
            try
            {
                Appointment appointment = _appointmentLogic.Read(id);
                return View(appointment);
            }
            catch (Exception)
            {
                return BadRequest("Appointment with the given ID doesn't exist");
            }
        }

        [HttpPost]
        public IActionResult EditAppointment(Appointment appointment)
        {
            ModelState.Remove("Service");
            if (!ModelState.IsValid)
            {
                return View(appointment);
            }

            try
            {
                _appointmentLogic.Update(appointment);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }

            return RedirectToAction("ServiceEdit", new { id = appointment.ServiceID });
        }

        [HttpGet]
        public IActionResult DeleteAppointment(string id)
        {
            try
            {
                Appointment appointment = _appointmentLogic.Read(id);
                _appointmentLogic.Delete(id);
                return RedirectToAction("ServiceEdit", new { id = appointment.ServiceID });
            }
            catch (Exception)
            {
                return BadRequest("Appointment with the given ID doesn't exist");
            }
        }

        public IActionResult ManageApplicants(string id)
        {
            try
            {
                Appointment appointment = _appointmentLogic.Read(id);
                return View(appointment);
            }
            catch (Exception)
            {
                return BadRequest("Appointment with the given ID doesn't exist");
            }
        }

        [HttpPost]
        public async Task<IActionResult> RemoveApplicant(string appointmentId, string applicantId)
        {
            try
            {
                Appointment appointment = _appointmentLogic.Read(appointmentId);

                var user = await _userManager.FindByIdAsync(applicantId);
                if (user == null)
                {
                    throw new ArgumentException("User to remove does not exist");
                }

                if (!appointment.Applicants.Contains(user))
                {
                    throw new ArgumentException("User isn't in the applicants list of this appointment");
                }

                appointment.Applicants.Remove(user!);
                _appointmentLogic.Update(appointment);

                return RedirectToAction(nameof(ManageApplicants), new { id = appointment.ID });
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        //public IActionResult AddTimeSlot()
        //{
        //    return View();
        //}

        //public IActionResult EditTimeSlot()
        //{
        //    return View();
        //}

        //public IActionResult AddPass()
        //{
        //    return View();
        //}

        //public IActionResult EditPass()
        //{
        //    return View();
        //}

        //public IActionResult DeletePass()
        //{
        //    return View();
        //}

        //public IActionResult DeleteTimeSlot()
        //{
        //    return View();
        //}
    }
}
