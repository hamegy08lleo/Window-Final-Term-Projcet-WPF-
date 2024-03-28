using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class Room
    {
        private string roomType;
        private string hotelID; 
        private int price;
        private float rating;
        private int amount;

        public Room(string roomType, string hotelID, int price, float rating, int amount)
        {
            this.roomType = roomType;
            this.hotelID = hotelID;
            this.price = price;
            this.rating = rating;
            this.amount = amount;
        }

        public string RoomType { get => roomType; set => roomType = value; }
        public string HotelID { get => hotelID; set => hotelID = value; }
        public int Price { get => price; set => price = value; }
        public float Rating { get => rating; set => rating = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
