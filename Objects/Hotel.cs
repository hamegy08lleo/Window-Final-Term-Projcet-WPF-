using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class Hotel
    {
        private string hotelName;
        private string city;
        private string address; 
        private string email;
        private string phoneNumber;
        private float rating;

        public Hotel(string hotelName, string address, string city, float rating, string email, string phoneNumber)
        {
            this.hotelName = hotelName;
            this.address = address;
            this.city = city;
            this.rating = rating;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }
        public Hotel(OwnerAddHotel hotel)
        {
            this.hotelName = hotel.HotelName; 
            this.address = hotel.Address;
            this.city = hotel.City;
            this.rating = 5.0F;
            this.email = hotel.Email;   
            this.phoneNumber = hotel.PhoneNumber;
        }
        public Hotel(DataRow row)
        {
            try
            {
                this.hotelName = row[1].ToString();
                this.city = row[2].ToString(); 
                this.address = row[3].ToString();
                this.email= row[4].ToString();  
                this.phoneNumber = row[5].ToString();   
                this.rating = float.Parse(row[6].ToString());       
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }
        }

        public string HotelName { get => hotelName; set => hotelName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public float Rating { get => rating; set => rating = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
