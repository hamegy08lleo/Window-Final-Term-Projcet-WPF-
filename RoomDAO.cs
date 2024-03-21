using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class RoomDAO
    {
        private string tableName;
        private DBConnection dbConnection; 

        public RoomDAO(string tableName)
        {
            this.tableName = tableName;
            this.dbConnection = new DBConnection(Properties.Settings.Default.connStr);
        }
        public void add(OwnerPost post)
        {
            Room room = new Room(post.RoomType, post.Hotel, post.City, post.Price, 5);
            string sqlStr = ""; 
            while (post.Amount > 0)
            {
                post.Amount -= 1; 
                sqlStr += $"INSERT INTO "
                     + $"{tableName}(roomType, hotel, city, price, rating) "
                     + $"VALUES ('{room.RoomType}', '{room.Hotel}', '{room.City}', '{room.Price}', '{room.Rating}')";
            }
            dbConnection.CommandExecute(sqlStr); 
        }

        public DataTable Search(CustomerSearch input)
        {
            String sqlStr = $"SELECT * FROM {tableName} " +
                $"WHERE {tableName}.city = '{input.City}' " +
                $"AND {tableName}.roomType = '{input.RoomType}'";
            DataTable dt = dbConnection.AdapterExecute(sqlStr);
            return dt;
        }
    }
}
