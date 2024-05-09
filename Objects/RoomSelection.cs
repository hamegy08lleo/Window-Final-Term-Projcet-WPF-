using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_
{
    public class RoomSelection
    {
        private Hotel hotel;
        private string roomType;
        private int price; 
        private int amount;

        public RoomSelection(Hotel hotel, string roomtype, int price, int amount)
        {
            this.hotel = hotel;
            roomType = roomtype;
            this.price = price;
            this.amount = amount;
        }

        public Hotel Hotel { get => hotel; set => hotel = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public int Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
