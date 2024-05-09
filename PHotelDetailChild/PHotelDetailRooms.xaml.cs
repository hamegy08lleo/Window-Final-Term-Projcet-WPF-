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
using Window_Final_Term_Projcet__WPF_.DataBase;

namespace Window_Final_Term_Projcet__WPF_.PHotelDetailChild
{
    /// <summary>
    /// Interaction logic for PHotelDetailRooms.xaml
    /// </summary>
    public partial class PHotelDetailRooms : Page
    {
        public PHotelDetailRooms()
        {
            InitializeComponent();
        }

        PHotelDetail pHotelDetail()
        {
            FrameworkElement frameworkElement = this;
            while (frameworkElement.Name != "pHotelDetail")
            {
                frameworkElement = VisualTreeHelper.GetParent(frameworkElement) as FrameworkElement;
            }
            return frameworkElement as PHotelDetail;
        }

        private void btnChoose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow.customerID == null)
            {
                WindowLogin windowLogin = new WindowLogin();
                windowLogin.Show();
                return;
            }
            BookingDAO bookingDAO = new BookingDAO();
            bookingDAO.addBooking(pHotelDetail().Selection);
            mainWindow.mainContent.Content = new PBooking(); 
        }
    }
}
