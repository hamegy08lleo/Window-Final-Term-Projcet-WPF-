using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_
{
    public class RoomSelection
    {
        private string hotelName;
        private string roomType;

        public RoomSelection(string hotelName, string roomType)
        {
            this.hotelName = hotelName;
            this.roomType = roomType;
        }

        public string HotelName { get => hotelName; set => hotelName = value; }
        public string RoomType { get => roomType; set => roomType = value; }
    }
}
