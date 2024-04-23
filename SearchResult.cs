using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Window_Final_Term_Projcet__WPF_
{
    public class SearchResult
    {
        private string roomType;
        private int? price;
        private int? bookingID;
        private Hotel hotel;
        private int amount;

        public string RoomType { get => roomType; set => roomType = value; }
        public int? Price { get => price; set => price = value; }
        public int? BookingID { get => bookingID; set => bookingID = value; }
        public Hotel Hotel { get => hotel; set => hotel = value; }
        public int Amount { get => amount; set => amount = value; }

        public SearchResult() { }

        public SearchResult(string roomType, int? price, int? bookingID, Hotel hotel, int amount)
        {
            this.roomType = roomType;
            this.price = price;
            this.bookingID = bookingID;
            this.hotel = hotel;
            this.amount = amount;
        }
    }
}