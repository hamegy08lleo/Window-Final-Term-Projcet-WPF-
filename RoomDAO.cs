using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class RoomDAO : DAO
    {
        public RoomDAO() : base("Room") { }
        public void Add(OwnerPostRoom post)
        {
            var (roomType, hotel, price, amount) = post;
            int hotelID = (new HotelDAO()).getHotelID(hotel);
            string tmp = $"INSERT INTO "
                + $"Room(hotelID, roomType, price) " +
                $"VALUES('{hotelID}', '{roomType}', '{price}') ";
            String sqlStr = String.Empty; 
            for (int i = 0; i < amount; i++)
            {
                sqlStr += tmp; 
            }
            dBConnection.CommandExecute(sqlStr);
        }

        public DataTable Search(CustomerSearch search)
        {
            string roomType = search.RoomType;
            string city = search.City;

            string sqlStr = $"SELECT hotelID, hotelName, address, price, rating, amount FROM " +
                            $"(SELECT Hotel.hotelID, Hotel.hotelName, roomType, city, address, price, rating, count(roomID) as 'amount' FROM " +
                            $"(SELECT * FROM " +
                            $"(SELECT Room.roomID, hotelID, roomType, price, bookingID FROM " +
                            $"Room left join Booking on Room.roomID = Booking.roomID) as Q1 " +
                            $"WHERE bookingID is null) as Q2 inner join Hotel on Hotel.hotelID = Q2.hotelID " +
                            $"GROUP BY Hotel.hotelID, Hotel.hotelName, roomtype, city, address, price, rating) as Q3 " +
                            $"WHERE roomType = '{roomType}' AND city = '{city}'";


            DataTable dt = dBConnection.AdapterExecute(sqlStr);
            return dt;
        }

        public string firstAvailableRoomID(RoomSelection selection)
        {
            string sqlStr = $"SELECT * FROM " +
                $"(SELECT roomID, Hotel.hotelID, roomType FROM " +
                $"Room inner join Hotel on Hotel.hotelID = Room.hotelID) as Q1 " +
                $"WHERE hotelID = '{selection.HotelID}' AND roomType = '{selection.RoomType}'";
            DataTable dt = new DataTable(); 
            try
            {
                dt = dBConnection.AdapterExecute(sqlStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt.Rows[0][0].ToString(); 
        }
    }
}
