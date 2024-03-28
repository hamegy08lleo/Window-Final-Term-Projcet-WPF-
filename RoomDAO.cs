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

        public DataTable Search(CustomerSearch input)
        {
            string roomType = input.RoomType;
            string city = input.City;

            string sqlStr = $"SELECT hotelID, hotelName, address, price, rating, ammount " +
                $"FROM " +
                $"(SELECT Hotel.hotelID, Hotel.hotelName, room.roomType, city, address, price, rating, count(roomID) as 'ammount' " +
                $"FROM " +
                $"Room inner join Hotel on Hotel.hotelID = Room.hotelID " +
                $"group by Hotel.hotelName, Hotel.hotelID, room.roomType, city, address, price, rating) as tmp " +
                $"WHERE roomType = '{roomType}' AND city = '{city}'";

            DataTable dt = dBConnection.AdapterExecute(sqlStr);
            return dt;

            //String sqlStr = $"SELECT * FROM {tableName} " +
            //    $"WHERE {tableName}.city = '{input.City}' " +
            //    $"AND {tableName}.roomType = '{input.RoomType}'";
            //DataTable dt = dBConnection.AdapterExecute(sqlStr);
            //return dt;
        }
    }
}
