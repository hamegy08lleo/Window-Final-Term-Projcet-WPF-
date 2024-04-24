using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class DAO
    {
        protected ManageRoomEntities dataBase; 
        public DAO()
        {
            dataBase = new ManageRoomEntities();
        }
    }
}
