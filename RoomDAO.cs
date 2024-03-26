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
        public void Add(OwnerPost post)
        {
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
