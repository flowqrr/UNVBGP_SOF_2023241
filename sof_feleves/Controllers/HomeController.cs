using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using sof_feleves.Logic.Interfaces;
using sof_feleves.Migrations;
using sof_feleves.Models;
using System.Diagnostics;

namespace sof_feleves.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<SiteUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IPostLogic _postLogic;

        public HomeController(
            ILogger<HomeController> logger,
            UserManager<SiteUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IPostLogic postLogic)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _postLogic = postLogic;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                if (await _userManager.IsInRoleAsync(user, "Host"))
                {
                    return LocalRedirect("/Host/Dashboard");
                }
                else
                {
                    return LocalRedirect("/Guest/Dashboard");
                }
            }

            return View();
        }

        public IActionResult GetProfilePic(string userid)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.Id == userid);
            return new FileContentResult(user.ProfilePicData, user.ProfilePicContentType);
        }

        public IActionResult GetPostImage(string postid)
        {
            Post post = _postLogic.Read(postid);
            return new FileContentResult(post.ImageData, post.ImageContentType);
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