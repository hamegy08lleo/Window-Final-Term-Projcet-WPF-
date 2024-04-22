using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class CustomerSearch
    {
        private string roomType;
        private string city;

        public CustomerSearch(string roomType, string city)
        {
            this.roomType = roomType;
            this.city = city;
        }

        public string RoomType { get => roomType; set => roomType = value; }
        public string City { get => city; set => city = value; }
    }
}
