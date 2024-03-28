using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_
{
    public class RoomSelection
    {
        private string hotelID;
        private string roomType;

        public RoomSelection(string hotelID, string roomType)
        {
            this.hotelID = hotelID;
            this.roomType = roomType;
        }

        public string HotelID { get => hotelID; set => hotelID = value; }
        public string RoomType { get => roomType; set => roomType = value; }
    }
}
