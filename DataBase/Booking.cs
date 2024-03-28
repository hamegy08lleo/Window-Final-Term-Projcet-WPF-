using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_.DataBase
{
    internal class Booking
    {
        private string roomID; 
        public Booking(string roomID)
        {
            this.roomID = roomID;
        }

        public string RoomID { get => roomID; set => roomID = value; }
    }
}
