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
    /// Interaction logic for PHotelDetail.xaml
    /// </summary>
    public partial class PHotelDetail : Page
    {
        public PHotelDetail()
        {
            InitializeComponent();
        }

        private void btnOverView_Click(object sender, RoutedEventArgs e)
        {
            detailContent.Content = new PHotelDetailOverView();
        }

        private void Romms_Click(object sender, RoutedEventArgs e)
        {
            detailContent.Content = new PHotelDetailChild.PHotelDetailRooms();
        }

        private void Review_Click(object sender, RoutedEventArgs e)
        {
            detailContent.Content = new PHotelDetailChild.PHotelDetailReview();
        }
    }
}
