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
        public int ownerID;
        public PPartnership(int ownerID)
        {
            InitializeComponent();
            HotelDAO hotelDAO = new HotelDAO();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            this.ownerID = ownerID;
            var hotels = hotelDAO.listHotel(ownerID); 
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
            Hotel hotel = (cbbHotel.SelectedItem as ComboBoxItem).Tag as Hotel;
            MessageBox.Show(hotel.hotelName);
            int price = int.Parse(txbPrice.Text);
            int amount = int.Parse(txbAmount.Text);
            OwnerPostRoom post = new OwnerPostRoom(roomType, hotel, price, amount);
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            var roomDAO = new RoomDAO(); 
            roomDAO.Add(post);
            new WNotifiaction().Notification("Success!"); 
        }

        private void cbbHotel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
