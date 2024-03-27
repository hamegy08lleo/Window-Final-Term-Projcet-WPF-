using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class HotelDAO : DAO
    {
        public HotelDAO() : base("Hotel") { }
        public void addHotel(OwnerAddHotel add)
        {
            Hotel hotel = new Hotel(add);
            String sqlStr = $"INSERT INTO {tableName}(hotelName, city, address, email phoneNumber, rating)"
                + $"VALUES('{hotel.HotelName}', '{hotel.City}', '{hotel.Address}', '{hotel.Email}', '{hotel.Email}', '{hotel.PhoneNumber}'
        }
    }
}
