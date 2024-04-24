using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class HotelDAO : DAO
    {
        public HotelDAO() { }
        public void addHotel(OwnerAddHotel add)
        {
            //string sqlStr = $"INSERT INTO Hotel(hotelName, city, address, email, phoneNumber, rating)" +
            //    $"VALUES('{add.HotelName}', '{add.City}', '{add.Address}', '{add.Email}', '{add.PhoneNumber}', '5.0')";
            //dBConnection.CommandExecute(sqlStr); 
            var db = new ManageRoomEntities(); 
            Hotel hotel = new Hotel {
                hotelName = add.HotelName,
                city = add.City,   
                address = add.Address,
                email = add.Email,
                phoneNumber = add.PhoneNumber,
                rating = 5.0
            };
            db.Hotel.Add(hotel);
            db.SaveChanges(); 
        }
        public Hotel getHotel(int id)
        {
            //string sqlStr = $"SELECT hotelName, address, city, rating, email, phoneNumber FROM " +
            //    $"Hotel " +
            //    $"WHERE hotelID = '{id}'";
            //DataTable dataTable = dBConnection.AdapterExecute(sqlStr);
            //string hotelName = dataTable.Rows[0][0].ToString();
            //string address = dataTable.Rows[0][1].ToString();   
            //string city = dataTable.Rows[0][2].ToString();
            //float rating = float.Parse(dataTable.Rows[0][3].ToString());
            //string email = dataTable.Rows[0][4].ToString();
            //string phoneNumber = dataTable.Rows[0][5].ToString();
            //Hotel hotel = new Hotel(hotelName, address, city, rating, email, phoneNumber);
            //return hotel; 

            var db = new ManageRoomEntities();
            var query = from q in db.Hotel
                        where q.hotelID == id
                        select q;
            return query.FirstOrDefault();
        }

        public IQueryable<Hotel> listHotel()
        {
            //string sqlStr = "SELECT hotelName FROM " +
            //    "Hotel";
            //DataTable dt = dBConnection.AdapterExecute(sqlStr);
            //return dt; 
            var db = new ManageRoomEntities();
            var query = from q in db.Hotel
                        select q;
            return query; 
        }
        //public int getHotelID(string hotelName)
        //{
        //    string sqlStr = "SELECT * FROM"
        //        + $" Hotel"
        //        + $" WHERE hotelName = '{hotelName}'";
        //    DataTable dt = dBConnection.AdapterExecute(sqlStr);
        //    int hotelID = -1;
        //    try
        //    {
        //        hotelID = int.Parse(dt.Rows[0][0].ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("The hotel does not exists");
        //    }
        //    return hotelID;
        //}
        //public DataRow getDataRow(string hotelID)
        //{
        //    string sqlStr = $"SELECT * FROM HOTEL WHERE hotelID = '{hotelID}'";
        //    DataTable dt = dBConnection.AdapterExecute(sqlStr);
        //    return dt.Rows[0]; 
        //}
    }
}
