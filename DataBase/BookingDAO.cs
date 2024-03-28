using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_.DataBase
{
    internal class BookingDAO : DAO
    {
        public BookingDAO() : base("Booking") { }
        public void addBooking(RoomSelection selection)
        {
            RoomDAO roomDAO = new RoomDAO();
            string roomID = roomDAO.firstAvailableRoomID(selection); 
            string sqlStr = "INSERT INTO " +
                $"Booking(roomID) " +
                $"VALUES('{roomID}')";
            dBConnection.CommandExecute(sqlStr);
        }
    }
}
