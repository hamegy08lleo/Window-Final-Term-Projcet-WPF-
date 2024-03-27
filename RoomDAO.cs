using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        }

        public DataTable Search(CustomerSearch input)
        {
            String sqlStr = $"SELECT * FROM {tableName} " +
                $"WHERE {tableName}.city = '{input.City}' " +
                $"AND {tableName}.roomType = '{input.RoomType}'";
            DataTable dt = dBConnection.AdapterExecute(sqlStr);
            return dt;
        }
    }
}
