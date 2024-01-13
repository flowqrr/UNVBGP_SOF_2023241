using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class StatisticsController : ControllerBase
{
    [HttpGet("totalUsers")]
    public IActionResult GetTotalUsers()
    {
        throw new NotImplementedException();
    }

    [HttpGet("hostsCount")]
    public IActionResult HostsCount()
    {
        throw new NotImplementedException();
    }

    [HttpGet("guestsCount")]
    public IActionResult GuestCount()
    {
        throw new NotImplementedException();
    }

    [HttpGet("servicesCount")]
    public IActionResult ServicesCount()
    {
        throw new NotImplementedException();
    }

    [HttpGet("servicesCount")]
    public IActionResult ServicesCount()
    {
        throw new NotImplementedException();
    }

}
