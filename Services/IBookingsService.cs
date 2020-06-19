using MySite_MVC.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite_MVC.Services
{
    public interface IBookingsService
    {
        List<Booking> GetAll();
        List<Booking> OneRoomBookings(int id);
        Booking MakeBooking(int user_id, int rehearsal_room_id, string booking_date);
        List<Booking> UsersBookings(int id);
    }
}
