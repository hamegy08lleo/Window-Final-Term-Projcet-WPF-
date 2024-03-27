using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class OwnerPostRoom
    {
        private string roomType;
        private string hotel;
        private int price;
        private int amount;

        public OwnerPostRoom(string roomType, string hotel, int price, int amount)
        {
            this.roomType = roomType;
            this.hotel = hotel;
            this.price = price;
            this.amount = amount;
        }

        public string RoomType { get => roomType; set => roomType = value; }
        public string Hotel { get => hotel; set => hotel = value; }
        public int Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
