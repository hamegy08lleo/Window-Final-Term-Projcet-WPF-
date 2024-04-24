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
using Window_Final_Term_Projcet__WPF_.PHotelDetailChild;

namespace Window_Final_Term_Projcet__WPF_
{
    /// <summary>
    /// Interaction logic for PHotelDetail.xaml
    /// </summary>
    public partial class PHotelDetail : Page
    {
        private RoomSelection selection;

        public RoomSelection Selection { get => selection; set => selection = value; }

        public PHotelDetail(RoomSelection selection)
        {
            InitializeComponent();
            PHotelDetailChild.PHotelDetailOverview pHotelDetailOverview = new PHotelDetailChild.PHotelDetailOverview();
            HotelDAO hotelDAO = new HotelDAO();
            Hotel hotel = selection.Hotel;
            pHotelDetailOverview.lblHotelName.Content = hotel.hotelName;
            pHotelDetailOverview.lblAddress.Content = hotel.address;
            pHotelDetailOverview.lblRating.Content = hotel.rating;
            string ratingstar = "";
            for (int i = 0; i < float.Parse(hotel.rating.ToString()); i++)
            {
                ratingstar += "⭐";
            }
            pHotelDetailOverview.lblRating.Content = ratingstar;
            //pHotelDetailOverview.lblPricOfRoom.Content = hotel.P
            detailContent.Content = pHotelDetailOverview;
            this.selection = selection;
        }

        private void btnRooms_Click(object sender, RoutedEventArgs e)
        {
            detailContent.Content = new PHotelDetailChild.PHotelDetailRooms();

        }

        private void btnReview_Click(object sender, RoutedEventArgs e)
        {
            detailContent.Content = new PHotelDetailChild.PHotelDetailReview();
        }

        private void btnOverView_Click(object sender, RoutedEventArgs e)
        {
            PHotelDetailChild.PHotelDetailOverview pHotelDetailOverview = new PHotelDetailChild.PHotelDetailOverview();
            HotelDAO hotelDAO = new HotelDAO();
            Hotel hotel = selection.Hotel;
            pHotelDetailOverview.lblHotelName.Content = hotel.hotelName;
            pHotelDetailOverview.lblAddress.Content = hotel.address;
            pHotelDetailOverview.lblRating.Content = hotel.rating;
            pHotelDetailOverview.lblPricOfRoom.Content = selection.Price;
            string ratingstar = "";
            for (int i = 0; i < float.Parse(hotel.rating.ToString()); i++)
            {
                ratingstar += "⭐";
            }
            pHotelDetailOverview.lblRating.Content = ratingstar;

            detailContent.Content = pHotelDetailOverview;


        }

        public PHotelDetail(Frame detailContent)
        {
            this.detailContent = detailContent;
        }
    }
}
