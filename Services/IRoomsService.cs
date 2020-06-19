using MySite_MVC.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite_MVC.Services
{
    public interface IRoomsService
    {
        List<Room> GetAll();
        public Room GetOne(int id);
        Room CreateRoom(string rehearsal_room_name, int user_id);
        List<Room> UsersRooms(int id);
    }
}
