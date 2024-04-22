using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class Room
    {
        private string roomType;
        private string hotelID; 
        private int price;

        public Room(string roomType, string hotelID, int price)
        {
            this.roomType = roomType;
            this.hotelID = hotelID;
            this.price = price;
        }
        public Room(DataRow row)
        {
            try
            {
                this.hotelID = row[1].ToString();
                this.roomType = row[2].ToString();
                this.price = int.Parse(row[3].ToString());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string RoomType { get => roomType; set => roomType = value; }
        public string HotelID { get => hotelID; set => hotelID = value; }
        public int Price { get => price; set => price = value; }
    }
}
