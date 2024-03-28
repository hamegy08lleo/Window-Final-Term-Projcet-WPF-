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
        public HotelDAO() : base("Hotel") { }
        public void addHotel(OwnerAddHotel add)
        {
        }
        public int getHotelID(string hotelName)
        {
            string sqlStr = "SELECT * FROM"
                + $" Hotel"
                + $" WHERE hotelName = '{hotelName}'";
            DataTable dt = dBConnection.AdapterExecute(sqlStr);
            int hotelID = -1;
            try
            {
                hotelID = int.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("The hotel does not exists");
            }
            return hotelID;
        }
    }
}
