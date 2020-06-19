using MySite_MVC.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite_MVC.Models
{
    public class ParentModel
{
        public User User { get; set; }
        public Room Room { get; set; }
        public Booking Booking { get; set; }
}
}
