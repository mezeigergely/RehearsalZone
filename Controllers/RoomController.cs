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
    [ApiController]
    [Route("[controller]")]
    public class RoomController : Controller
    {
        private readonly ILogger<RoomController> _logger;
        private readonly IRoomsService _roomsService;
        private readonly IBookingsService _bookingsService;

        public RoomController(ILogger<RoomController> logger, IRoomsService roomsService, IBookingsService bookingsService)
        {
            _logger = logger;
            _roomsService = roomsService;
            _bookingsService = bookingsService;
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("[action]")]
        public IActionResult AllRooms()
        {
            return View(_roomsService.GetAll());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("[action]")]
        public JsonResult GetAll(/*string name*/)
        {
            //Room room = _roomsService.GetOne(name);
            //return Json(room);
            List<Room> rooms = _roomsService.GetAll();
            return Json(rooms);
        }

        [HttpGet]
        [Route("{id}")]
        public JsonResult GetOne(int id)
        {
            Room room = _roomsService.GetOne(id);
            return Json(room);
        }

        [HttpGet]
        [Route("[action]")]
        public List<Booking> GetAllBooking()
        {
            List<Booking> bookings = _bookingsService.GetAll();
            return bookings;
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public List<Booking> GetOneRoomBookings(int id)
        {
            List<Booking> bookings = _bookingsService.OneRoomBookings(id);
            return bookings;
        }

        [HttpGet]
        public IActionResult MakeBooking()
        {
            return View();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult MakeBooking([FromForm] int rehearsal_room_id, [FromForm] string booking_date)
        {
            var user_id = int.Parse(HttpContext.User.FindFirstValue("user_id"));
            Booking booking = _bookingsService.MakeBooking(user_id, rehearsal_room_id, booking_date);
            if (booking != null)
            {
                return Json(booking);
            }
            return BadRequest();

        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult BookingError()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateRoom()
        {
            return View();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult CreateRoom([FromForm] string rehearsal_room_name)
        {
            var user_id = int.Parse(HttpContext.User.FindFirstValue("user_id"));
            return View(_roomsService.CreateRoom(rehearsal_room_name, user_id));
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public List<Room> UsersRooms(int id)
        {
            List<Room> rooms = _roomsService.UsersRooms(id);
            return rooms;
        }
    }
}
