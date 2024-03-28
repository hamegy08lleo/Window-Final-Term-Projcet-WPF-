using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class DAO
    {
        protected string tableName;
        protected DBConnection dBConnection; 
        public DAO(string tableName)
        {
            this.tableName = tableName;
            dBConnection = new DBConnection(Properties.Settings.Default.connStr); 
        }
    }
}
