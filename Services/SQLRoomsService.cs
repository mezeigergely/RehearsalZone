using MySite_MVC.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace MySite_MVC.Services
{
    public class SQLRoomsService : IRoomsService
    {
        public Room CreateRoom(string rehearsal_room_name, int user_id)
        {
            using (var conn = new NpgsqlConnection(Program.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO rehearsal_rooms (rehearsal_room_name, user_id)" +
                                                    "VALUES (@rehearsal_room_name, @user_id)", conn))
                {
                    cmd.Parameters.AddWithValue("rehearsal_room_name", rehearsal_room_name);
                    cmd.Parameters.AddWithValue("user_id", user_id);
                    cmd.ExecuteNonQuery();
                }
                return new Room { Name = rehearsal_room_name, UserID = user_id.ToString() };
            }
        }

        public List<Room> GetAll()
        {
            List<Room> allRoom = new List<Room>();

            using (var conn = new NpgsqlConnection(Program.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM rehearsal_rooms", conn))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string rehearsal_room_id = reader["rehearsal_room_id"].ToString();
                        string rehearsal_room_name = reader["rehearsal_room_name"].ToString();
                        string user_id = reader["user_id"].ToString();
                        Room room = new Room { ID = int.Parse(rehearsal_room_id), Name = rehearsal_room_name, UserID = user_id };
                        allRoom.Add(room);
                    }
                }
                return allRoom;
            }
        }

        public Room GetOne(int id)
        {
            List<Room> allRoom = GetAll();
            return allRoom.FirstOrDefault(u => u.ID == id);
        }

        public List<Room> UsersRooms(int id)
        {
            List<Room> allRoom = new List<Room>();

            using (var conn = new NpgsqlConnection(Program.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM rehearsal_rooms WHERE user_id = @id", conn))
                {
                    var userIdParam = cmd.CreateParameter();
                    userIdParam.ParameterName = "id";
                    userIdParam.Value = id;

                    cmd.Parameters.Add(userIdParam);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string rehearsal_room_id = reader["rehearsal_room_id"].ToString();
                        string rehearsal_room_name = reader["rehearsal_room_name"].ToString();
                        string temp_user_id = reader["user_id"].ToString();
                        Room booking = new Room
                        {
                            ID = int.Parse(rehearsal_room_id),
                            Name = rehearsal_room_name,
                            UserID = temp_user_id
                        };

                        allRoom.Add(booking);
                    }
                }
                return allRoom;
            }
        }
    }
}
