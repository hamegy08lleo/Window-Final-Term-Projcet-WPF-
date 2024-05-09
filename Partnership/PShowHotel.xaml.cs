using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Window_Final_Term_Projcet__WPF_
{
    /// <summary>
    /// Interaction logic for PShowHotel.xaml
    /// </summary>
    public partial class PShowHotel : Page
    {
        public int ownerID;
        public PShowHotel(int ownerID)
        {
            InitializeComponent();
            HotelDAO hotelDAO = new HotelDAO();
            this.ownerID = ownerID;
            var hotels = hotelDAO.listHotel(ownerID);
            foreach (var hotel in hotels) 
            {
                UCHotel ucHotel = new UCHotel();
                ucHotel.lblHotelName.Content = hotel.hotelName; 
                this.spHotel.Children.Add(ucHotel); 
            }
        }
    }
}
