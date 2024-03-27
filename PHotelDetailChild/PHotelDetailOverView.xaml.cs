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

namespace Window_Final_Term_Projcet__WPF_.PHotelDetailChild
{
    /// <summary>
    /// Interaction logic for PHotelDetailOverview.xaml
    /// </summary>
    public partial class PHotelDetailOverview : Page
    {
        public PHotelDetailOverview()
        {
            InitializeComponent();
        }


        private void btnSelectRoom_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = Window.GetWindow(this) as MainWindow;
            PHotelDetail pHotelDetail = window.MainContent.Content as PHotelDetail;
            pHotelDetail.detailContent.Navigate(new PHotelDetailChild.PHotelDetailRooms());
           
        }
    }
}
