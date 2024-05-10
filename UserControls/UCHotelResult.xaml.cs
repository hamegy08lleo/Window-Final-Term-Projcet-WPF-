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
    /// Interaction logic for UCHotelResult.xaml
    /// </summary>
    public partial class UCHotelResult : UserControl
    {
        private RoomSelection selection;
        public UCHotelResult(RoomSelection selection)
        {
            InitializeComponent();
            this.selection = selection;

            this.lblHotelName.Content = selection.Hotel.hotelName.ToString();
            this.lblAddress.Content = selection.Hotel.address;
            this.lblPrice.Content = selection.Price.ToString() + "$";

            string rating = "";
            for (int i = 0; i < float.Parse(selection.Hotel.rating.ToString()); i++)
            {
                rating += "⭐";
            }
            this.lblRating.Content = rating;
            this.btnSelectRoom.Click += this.btnSelectRoom_Click;
        }

        public RoomSelection Selection { get => selection; set => selection = value; }

        public void btnSelectRoom_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            PHotelDetail pHotelDetail = new PHotelDetail(selection);
            pHotelDetail.Name = "pHotelDetail";
            mainWindow.MainContent.Navigate(pHotelDetail);
        }
    }
}
