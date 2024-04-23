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
            var db = new ManageRoomEntities();
            for (int i = 0; i < amount; i++)
            {
                var room = new Room
                {
                    hotelID = hotel.hotelID,
                    price = price,
                    roomType = roomType,
                };
                db.Room.Add(room);
            }
        }

        public IQueryable<SearchResult> Search(CustomerSearch search)
        {
            var query = (from q4 in
                            (from q2 in
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
                                 q1.bookingID,
                                 hotel,
                             })
                             group q2
                             by new
                             {
                                 q2.roomType,
                                 q2.price,
                                 q2.bookingID,
                                 q2.hotel,
                             } into q3
                             select new
                             {
                                 q3.Key.roomType,
                                 q3.Key.price,
                                 q3.Key.bookingID,
                                 q3.Key.hotel,
                                 amount = q3.Count(),
                             })
                         where (q4.hotel.city == search.City) && (q4.roomType == search.RoomType)
                         select new SearchResult {
                             RoomType = q4.roomType,
                             Price = q4.price,
                             BookingID = q4.bookingID,
                             Hotel = q4.hotel,
                             Amount = q4.amount,
                         }); 
            
            
            return query;
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

            var db = new ManageRoomEntities();
            var query = from hotel in db.Hotel
                        join room in db.Room on hotel.hotelID equals room.roomID
                        where hotel.hotelID == selection.Hotel.hotelID && room.roomType == selection.RoomType
                        select new
                        {
                            room.roomID,
                            hotel.hotelID,
                            room.roomType,
                        };
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
