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
        private string hotel;
        private string city; 
        private int price;
        private float rating;

        public Room(string roomType, string hotel,string city, int price, float rating)
        {
            this.roomType = roomType;
            this.hotel = hotel;
            this.city = city; 
            this.price = price;
            this.rating = rating;
        }

        public string RoomType { get => roomType; set => roomType = value; }
        public string Hotel { get => hotel; set => hotel = value; }
        public int Price { get => price; set => price = value; }
        public float Rating { get => rating; set => rating = value; }
        public string City { get => city; set => city = value; }
    }
}
