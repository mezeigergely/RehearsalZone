using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySite_MVC.Domain;
using MySite_MVC.Models;
using MySite_MVC.Services;

namespace MySite_MVC.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly IUsersService _usersService;
        public ProfileController(ILogger<ProfileController> logger, IUsersService usersService)
        {
            _logger = logger;
            _usersService = usersService;
        }

        public IActionResult Index()
        {
            var name = HttpContext.User.Claims.First(c => c.Type == ClaimTypes.Name).Value;
            User user = _usersService.GetOne(name);
            return View(new User
            {
                ID = user.ID,
                Name = user.Name,
                Password = user.Password
            });
        }
    }
}
