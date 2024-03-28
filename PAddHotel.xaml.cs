using System;
using System.Collections.Generic;
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
        /// Interaction logic for PAddHotel.xaml
        /// </summary>
        public partial class PAddHotel : Page
        {
                public PAddHotel()
                {
                        InitializeComponent();
                }

        private void btnPost_Click(object sender, RoutedEventArgs e)
        {
            string hotelName = txtHotelName.Text;
            string city = cbbCity.Text;
            string address = txtAddress.Text;  
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            OwnerAddHotel add = new OwnerAddHotel(hotelName, address, city, email, phoneNumber); 
            HotelDAO hotelDAO = new HotelDAO();
            hotelDAO.addHotel(add); 
        }
    }
}
