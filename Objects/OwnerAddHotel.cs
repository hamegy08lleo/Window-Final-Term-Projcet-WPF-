using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class OwnerAddHotel
    {
        private String hotelName;
        private String address; 
        private String city;
        private String email;
        private String phoneNumber;
        private int ownerID; 

        public OwnerAddHotel(string hotelName, string address, string city, string email, string phoneNumber, int ownerID)
        {
            this.hotelName = hotelName;
            this.address = address;
            this.city = city;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.ownerID = ownerID;
        }
        public string HotelName { get => hotelName; set => hotelName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int OwnerID { get => ownerID; set => ownerID = value; }
    }
}
