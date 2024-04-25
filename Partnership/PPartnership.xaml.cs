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
    /// Interaction logic for PPartnership.xaml
    /// </summary>
    public partial class PPartnership : Page
    {
        public PPartnership()
        {
            InitializeComponent();
            HotelDAO hotelDAO = new HotelDAO();
            var hotels = hotelDAO.listHotel(); 
            foreach(Hotel hotel in hotels)
            {

                ComboBoxItem item = new ComboBoxItem();
                item.Content = hotel.hotelName; 
                item.Tag = hotel;
                cbbHotel.Items.Add(item);
            }
        }

        private void btnPost_Click(object sender, RoutedEventArgs e)
        {
            string roomType = cbbRoomType.Text;
            Hotel hotel = cbbHotel.Tag as Hotel; 
            int price = int.Parse(txbPrice.Text);
            int amount = int.Parse(txbAmount.Text);
            OwnerPostRoom post = new OwnerPostRoom(roomType, hotel, price, amount);
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            var roomDAO = new RoomDAO(); 
            roomDAO.Add(post);
        }

        private void cbbHotel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Hotel hotel = cbbHotel.Tag as Hotel;
            MessageBox.Show("hello"); 
            MessageBox.Show(hotel.hotelID.ToString()); 
        }
    }
}
