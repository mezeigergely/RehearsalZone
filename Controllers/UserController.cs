using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySite_MVC.Domain;
using MySite_MVC.Models;
using MySite_MVC.Services;
using Npgsql;

namespace MySite_MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUsersService _usersService;

        
        public UserController(ILogger<UserController> logger, IUsersService usersService)
        {
            _logger = logger;
            _usersService = usersService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult AllUsers()
        {
            return View(_usersService.GetAll());
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm] string user_name, [FromForm]string user_password)
        {
            if (user_name.Length == 0 || user_password.Length == 0)
            {
                ViewData["Message"] = "Wrong input!";
            }
            ViewData["Message"] = "Registration succesfull!";
            return View(_usersService.Register(user_name, user_password));
        }
    }
}
