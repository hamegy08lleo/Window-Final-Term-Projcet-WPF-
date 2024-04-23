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


        public RoomSelection(Hotel hotel, string roomType, int price)
        {
            this.hotel = hotel;
            this.roomType = roomType;
            this.price = price;
        }

        public Hotel Hotel { get => hotel; set => hotel = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public int Price { get => price; set => price = value; }
    }
}
