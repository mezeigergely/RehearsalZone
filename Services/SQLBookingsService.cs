using MySite_MVC.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace MySite_MVC.Services
{
    public class SQLBookingsService : IBookingsService
    {

        public List<Booking> GetAll()
        {
            List<Booking> bookings = new List<Booking>();

            using (var conn = new NpgsqlConnection(Program.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM booking", conn))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string user_id = reader["user_id"].ToString();
                        string rehearsal_room_id = reader["rehearsal_room_id"].ToString();
                        string booking_date = reader["booking_date"].ToString();
                        Booking booking = new Booking
                        {
                            User_ID = int.Parse(user_id),
                            Rehearsal_Room_ID = int.Parse(rehearsal_room_id),
                            Booking_Date = booking_date
                        };

                        bookings.Add(booking);
                    }
                }
                return bookings;
            }
        }

        public List<Booking> OneRoomBookings(int id)
        {
            List<Booking> bookings = new List<Booking>();

            using (var conn = new NpgsqlConnection(Program.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM booking WHERE rehearsal_room_id = @id", conn))
                {
                    var userIdParam = cmd.CreateParameter();
                    userIdParam.ParameterName = "id";
                    userIdParam.Value = id;

                    cmd.Parameters.Add(userIdParam);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string user_id = reader["user_id"].ToString();
                        string rehearsal_room_id = reader["rehearsal_room_id"].ToString();
                        string booking_date = reader["booking_date"].ToString();
                        Booking booking = new Booking
                        {
                            User_ID = int.Parse(user_id),
                            Rehearsal_Room_ID = int.Parse(rehearsal_room_id),
                            Booking_Date = booking_date
                        };

                        bookings.Add(booking);
                    }
                }
                return bookings;
            }
        }

        public Booking MakeBooking(int user_id, int rehearsal_room_id, string booking_date)
        {
            Booking booking;
            List<Booking> bookings = OneRoomBookings(rehearsal_room_id);
            foreach (var item in bookings)
            {
                if (item.Booking_Date == booking_date)
                {
                    return null;
                }
            }
            using (var conn = new NpgsqlConnection(Program.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO booking (user_id, rehearsal_room_id, booking_date)" +
                                                    "VALUES (@user_id, @rehearsal_room_id, @booking_date)", conn))
                {
                    cmd.Parameters.AddWithValue("user_id", user_id);
                    cmd.Parameters.AddWithValue("rehearsal_room_id", rehearsal_room_id);
                    cmd.Parameters.AddWithValue("booking_date", booking_date);
                    cmd.ExecuteNonQuery();
                }
            }
            booking = new Booking { User_ID = user_id, Rehearsal_Room_ID = rehearsal_room_id, Booking_Date = booking_date };


            return booking;
        }

        public List<Booking> UsersBookings(int id)
        {
            List<Booking> allRoom = new List<Booking>();

            using (var conn = new NpgsqlConnection(Program.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM booking WHERE user_id = @id ORDER BY booking_date", conn))
                {
                    var userIdParam = cmd.CreateParameter();
                    userIdParam.ParameterName = "id";
                    userIdParam.Value = id;

                    cmd.Parameters.Add(userIdParam);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string user_id = reader["user_id"].ToString();
                        string rehearsal_room_id = reader["rehearsal_room_id"].ToString();
                        string booking_date = reader["booking_date"].ToString();
                        Booking booking = new Booking
                        {
                            User_ID = int.Parse(user_id),
                            Rehearsal_Room_ID = int.Parse(rehearsal_room_id),
                            Booking_Date = booking_date
                        };

                        allRoom.Add(booking);
                    }
                }
                return allRoom;
            }
        }
    }
}
