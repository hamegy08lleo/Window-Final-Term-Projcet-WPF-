using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Window_Final_Term_Projcet__WPF_.Objects
{
    internal class ImageDAO : DAO
    {
        public void add(String imagePath, int hotelID)
        {
            ImageItem item = new ImageItem();
            item.imagePath = imagePath;
            item.hotelID = hotelID;

            dataBase.ImageItem.Add(item);
            dataBase.SaveChanges();
        }
    }
}
