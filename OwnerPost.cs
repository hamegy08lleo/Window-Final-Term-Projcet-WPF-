using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class OwnerPost
    {
        private string roomType;
        private string hotel;
        private string city;
        private int price;
        private int amount;

        public OwnerPost(string roomType, string hotel, string city, int price, int amount)
        {
            this.roomType = roomType;
            this.hotel = hotel;
            this.city = city;
            this.price = price;
            this.amount = amount;
        }

        public string RoomType { get => roomType; set => roomType = value; }
        public string Hotel { get => hotel; set => hotel = value; }
        public string City { get => city; set => city = value; }
        public int Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
