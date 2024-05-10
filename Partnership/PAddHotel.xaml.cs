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
using Window_Final_Term_Projcet__WPF_.Objects;
using Window_Final_Term_Projcet__WPF_.PostHotelChild;

namespace Window_Final_Term_Projcet__WPF_
{
    public partial class PAddHotel : Page
    {
        public PAddHotel()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, RoutedEventArgs e)
        {
            string hotelName = ucPostGeneral.txtHotelName.Text;
            string city = ucPostGeneral.cbbCity.Text;
            string address = ucPostGeneral.txtAddress.Text;
            string ownerName = ucPostGeneral.txtOwnerName.Text;
            string email = ucPostGeneral.txtEmail.Text;
            string phoneNumber = ucPostGeneral.txtPhoneNumber.Text;

            Boolean swim = ucPostFacilities.btnSwimmingPool.IsChecked.Value;
            Boolean casino = ucPostFacilities.btnCasino.IsChecked.Value;
            Boolean wheelChair = ucPostFacilities.btnWheelchairAccess.IsChecked.Value;
            Boolean parking = ucPostFacilities.btnParking.IsChecked.Value;
            Boolean Restaurant = ucPostFacilities.btnRestaurant.IsChecked.Value;
            Boolean fitness = ucPostFacilities.btnFitnessCenter.IsChecked.Value;
            Boolean airport = ucPostFacilities.btnAirportTransfer.IsChecked.Value;
            Boolean meeting = ucPostFacilities.btnMeetingFacilities.IsChecked.Value;
            // add hotel xong roi add Hinh

            int ownerID = (Window.GetWindow(this) as MainWindow).ownerID.Value; 
            OwnerAddHotel ownerAddHotel = new OwnerAddHotel(hotelName, address, city, email, phoneNumber, ownerID);
            HotelDAO hotelDAO = new HotelDAO();
            int hotelID = hotelDAO.addHotel(ownerAddHotel);
            ImageDAO imageDAO = new ImageDAO();
            List<string> imagesPath = ucPostImage.imagesPath; 
            foreach(string imagePath in imagesPath)
            {
                imageDAO.add(imagePath, hotelID);    
            }
            new WNotifiaction().Notification("Success"); 
        }
    }
}
