using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.TextFormatting;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class RoomDAO : DAO
    {
        public RoomDAO() { }
        public void Add(OwnerPostRoom post)
        {
            //var (roomType, hotel, price, amount) = post;
            //int hotelID = (new HotelDAO()).getHotelID(hotel);
            //string tmp = $"INSERT INTO "
            //    + $"Room(hotelID, roomType, price) " +
            //    $"VALUES('{hotelID}', '{roomType}', '{price}') ";
            //String sqlStr = String.Empty; 
            //for (int i = 0; i < amount; i++)
            //{
            //    sqlStr += tmp; 
            //}
            //dBConnection.CommandExecute(sqlStr);

            var (roomType, hotel, price, amount) = post;
            for (int i = 0; i < amount; i++)
            {
                var room = new Room
                {
                    hotelID = hotel.hotelID,
                    price = price,
                    roomType = roomType,
                };
                dataBase.Room.Add(room);
            }
            dataBase.SaveChanges();
        }

        public void Search(CustomerSearch search)
        {
            var query = (from q2 in
                            (from q1 in
                             (from room in dataBase.Room
                              join booking in dataBase.Booking on room.roomID equals booking.roomID
                              into temp
                              from item in temp.DefaultIfEmpty()
                              select new
                              {
                                  room.roomID,
                                  room.roomType,
                                  room.price,
                                  room.hotelID,
                                  bookingID = (int?)item.bookingID,
                              })
                             where q1.bookingID == null
                             join hotel in dataBase.Hotel on q1.hotelID equals hotel.hotelID
                             select new
                             {
                                 q1.roomID,
                                 q1.roomType,
                                 q1.price,
                                 hotel,
                             })
                         where(q2.hotel.city == search.City) && (q2.roomType == search.RoomType)
                         select q2).ToList();
            dataBase.SearchResult.RemoveRange(dataBase.SearchResult.ToList());
            foreach (var result in query)
            {
                var searchResult = new SearchResult
                {
                    hotelID = result.hotel.hotelID,
                    roomType = result.roomType,
                    roomID = result.roomID,
                    price = result.price,
                };
                dataBase.SearchResult.Add(searchResult);
            }
            dataBase.SaveChanges();
        }

        public int firstAvailableRoomID(RoomSelection selection)
        {
            //string sqlStr = $"SELECT * FROM " +
            //    $"(SELECT roomID, Hotel.hotelID, roomType FROM " +
            //    $"Room inner join Hotel on Hotel.hotelID = Room.hotelID) as Q1 " +
            //    $"WHERE hotelID = '{selection.HotelID}' AND roomType = '{selection.RoomType}'";
            //DataTable dt = new DataTable(); 
            //try
            //{
            //    dt = dBConnection.AdapterExecute(sqlStr);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //return dt.Rows[0][0].ToString(); 

            MessageBox.Show($"{selection.Hotel.hotelID.ToString()}, {selection.RoomType}");
            var query = from q in dataBase.SearchResult
                        where q.hotelID == selection.Hotel.hotelID && q.roomType == selection.RoomType
                        select q;
            MessageBox.Show(query.Count().ToString());
            foreach (var q in query)
            {
                MessageBox.Show($"{q.roomType}, hehe");
            }
            return query.FirstOrDefault().roomID;
        }

        //public DataRow getDataRow(string roomID)
        //{
        //    string sqlStr = $"SELECT * FROM ROOM WHERE roomID = '{roomID}'";
        //    DataTable dt = dBConnection.AdapterExecute(sqlStr);
        //    return dt.Rows[0]; 
        //}

        public Room getRoom(int id)
        {
            var query = from room in dataBase.Room
                        where room.roomID == id
                        select room;
            return query.FirstOrDefault();
        }
    }
}
