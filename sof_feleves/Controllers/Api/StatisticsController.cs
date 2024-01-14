using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using sof_feleves.Logic.Interfaces;
using sof_feleves.Models;
using sof_feleves.Other;
using Syncfusion.EJ2.FileManager;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class StatisticsController : ControllerBase
{
    private readonly UserManager<SiteUser> _userManager;
    private readonly IServiceLogic _serviceLogic;

    public StatisticsController(UserManager<SiteUser> userManager,
                                IServiceLogic serviceLogic)
    {
        _userManager = userManager;
        _serviceLogic = serviceLogic;
    }

    [HttpGet("totalUsers")]
    public async Task<IActionResult> GetTotalUsers()
    {
        try
        {
            var totalUsers = await _userManager.Users.CountAsync();
            return Ok(new { TotalUsers = totalUsers });
        }
        catch (Exception ex)
        {
            return BadRequest("Something went wrong while trying to get total number of users");
        }
    }

    [HttpGet("hostsCount")]
    public async Task<IActionResult> HostsCount()
    {
        try
        {
            int hostsCount = (await _userManager.GetUsersInRoleAsync("Host")).Count;
            return Ok(new { HostsCount = hostsCount });
        }
        catch (Exception ex)
        {
            return BadRequest("Something went wrong while trying to get number of Host users");
        }
    }

    [HttpGet("guestsCount")]
    public async Task<IActionResult> GuestCount()
    {
        try
        {
            int allUsers = await _userManager.Users.CountAsync();
            int usersInHostRole = (await _userManager.GetUsersInRoleAsync("Host")).Count;
            int guestsCount = allUsers - usersInHostRole;

            return Ok(new { GuestsCount = guestsCount });
        }
        catch (Exception ex)
        {
            return BadRequest("Something went wrong while trying to get number of Guest users");
        }
    }

    [HttpGet("servicesCount")]
    public IActionResult ServicesCount()
    {
        try
        {
            int servicesCount = _serviceLogic.CountItems();

            return Ok(new { ServicesCount = servicesCount });
        }
        catch (Exception ex)
        {
            return BadRequest("Something went wrong while trying to get number of services");
        }
    }
}
