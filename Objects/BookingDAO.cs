using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Window_Final_Term_Projcet__WPF_.DataBase
{
    internal class BookingDAO : DAO
    {
        public BookingDAO() { }
        public void addBooking(RoomSelection selection, int customerID)
        {
            //RoomDAO roomDAO = new RoomDAO();
            //int roomID = roomDAO.firstAvailableRoomID(selection); 
            //string sqlStr = "INSERT INTO " +
            //    $"Booking(roomID) " +
            //    $"VALUES('{roomID}')";
            //dBConnection.CommandExecute(sqlStr);
            RoomDAO roomDAO = new RoomDAO();
            int roomID = roomDAO.firstAvailableRoomID(selection);

            dataBase.Booking.Add(new Booking
            {
                roomID = roomID,
                customerID = customerID,
            });
            dataBase.SaveChanges(); 
        }
        public void cancelBooking(int bookingID)
        {
            dataBase.Booking.Remove((from booking 
                                    in dataBase.Booking 
                                    where booking.bookingID == bookingID
                                    select booking).FirstOrDefault());
            dataBase.SaveChanges();
        }
        public IQueryable<Booking> listBooking()
        {
            //string sqlStr = $"SELECT * FROM BOOKING";
            //DataTable dt = dBConnection.AdapterExecute(sqlStr);
            //return dt; 

            var query = from booking in dataBase.Booking
                        select booking;
            return query; 
        }
    }
}
