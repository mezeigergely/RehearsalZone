using MySite_MVC.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite_MVC.Services
{
    public interface IUsersService
    {
        List<User> GetAll();
        public User GetOne();
        public User GetOne(string name);
        public User GetOne(int id);
        public User GetOne(string name, string password);
        User Register(string user_name, string user_password);
        public User Login(string name, string password);


    }
}
