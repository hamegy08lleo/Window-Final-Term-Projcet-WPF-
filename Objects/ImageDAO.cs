using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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
        public BitmapImage get(Hotel hotel)
        {
            MessageBox.Show(hotel.hotelID.ToString()); 
            var query = from q in dataBase.ImageItem
                        where q.hotelID == hotel.hotelID
                        select q;
            if (query.Count() == 0)
            {
                return null;
            }
            
            MessageBox.Show(query.FirstOrDefault().imagePath); 
            return new BitmapImage(new Uri(query.FirstOrDefault().imagePath));
        }
    }
}
