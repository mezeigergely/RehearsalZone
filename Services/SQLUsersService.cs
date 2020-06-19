using MySite_MVC.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace MySite_MVC.Services
{
    public class SQLUsersService : IUsersService
    {        
        public User Register(string user_name, string user_password)
        {
            using (var conn = new NpgsqlConnection(Program.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO users(user_name, user_password) VALUES(@user_name, @user_password);", conn))
                {
                    cmd.Parameters.AddWithValue("user_name", user_name);
                    cmd.Parameters.AddWithValue("user_password", user_password);
                    cmd.ExecuteNonQuery();
                }
            }
            return new User { Name = user_name, Password = user_password };
        }



        public List<User> GetAll()
        {
            List<User> allUser = new List<User>();
            using (var conn = new NpgsqlConnection(Program.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM users", conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string user_id = reader["user_id"].ToString();
                        string user_name = reader["user_name"].ToString();
                        string user_password = reader["user_password"].ToString();
                        User user = new User { ID = int.Parse(user_id), Name = user_name, Password = user_password };
                        allUser.Add(user);
                    }
                }
                return allUser;
            }
        }

        public User GetOne(int id)
        {
            List<User> allUser = GetAll();
            return allUser.FirstOrDefault(u => u.ID == id);
        }

        public User GetOne()
        {
            List<User> allUser = GetAll();
            foreach (var item in allUser)
            {
                return item;
            }
            return null;
        }

        public User GetOne(string name, string password)
        {
            List<User> allUser = GetAll();
            foreach (var user in allUser)
            {
                if (user.Name == name && user.Password == password)
                {
                    return user;
                }
            }
            return null;

            //List<User> allUser = GetAll();
            //return allUser.FirstOrDefault(u => u.Name == name);
        }

        public User GetOne(string name)
        {
            List<User> allUser = GetAll();
            return allUser.FirstOrDefault(u => u.Name == name);
        }

        public User Login(string name, string password)
        {
            var user = GetOne(name);
            if (user == null)
            {
                return null;
            }
            if (user.Password != password)
            {
                return null;
            }
            return user;
        }
    }
}
