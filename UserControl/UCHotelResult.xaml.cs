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

namespace Window_Final_Term_Projcet__WPF_{
    /// <summary>
    /// Interaction logic for UCHotelResult.xaml
    /// </summary>
    public partial class UCHotelResult : UserControl
    {
        private RoomSelection selection;
        public UCHotelResult(Hotel hotel, string roomType)
        {
            InitializeComponent();
            this.selection = new RoomSelection(hotel, roomType);
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
