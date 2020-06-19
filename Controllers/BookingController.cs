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

namespace MySite_MVC.Controllers
{
    [Route("[controller]")]
    public class BookingController : Controller
    {
        private readonly ILogger<BookingController> _logger;
        private readonly IBookingsService _bookingsService;


        public BookingController(ILogger<BookingController> logger, IBookingsService bookingsService)
        {
            _logger = logger;
            _bookingsService = bookingsService;
        }

        //[HttpGet]
        //public IActionResult AllBookings()
        //{
        //    return View(_bookingsService.GetAll());
        //}

        //[HttpGet]
        //public List<Booking> GetAll()
        //{
        //    List<Booking> bookings = _bookingsService.GetAll();
        //    return bookings;
        //}

        [HttpGet]
        public JsonResult GetAll(/*string name*/)
        {
            //Room room = _roomsService.GetOne(name);
            //return Json(room);
            List<Booking> bookings = _bookingsService.GetAll();
            return Json(bookings);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public List<Booking> UsersBookings(int id)
        {
            List<Booking> bookings = _bookingsService.UsersBookings(id);
            return bookings;
        }
    }
}
