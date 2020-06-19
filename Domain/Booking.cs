using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite_MVC.Domain
{
    public class Booking
    {
        public int User_ID { get; set; }
        public int Rehearsal_Room_ID { get; set; }
        public string Booking_Date { get; set; }
    }
}
