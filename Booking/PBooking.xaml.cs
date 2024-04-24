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
using Window_Final_Term_Projcet__WPF_.DataBase;

namespace Window_Final_Term_Projcet__WPF_
{
    /// <summary>
    /// Interaction logic for PBooking.xaml
    /// </summary>
    public partial class PBooking : Page
    {
        public PBooking()
        {
            InitializeComponent();

            BookingDAO bookingDAO = new BookingDAO();  
            RoomDAO roomDAO = new RoomDAO();
            HotelDAO hotelDAO = new HotelDAO();

            var bookings = bookingDAO.listBooking(); 
            foreach(var booking in bookings)
            {
                Room room = roomDAO.getRoom(booking.roomID);
                Hotel hotel = hotelDAO.getHotel(room.hotelID);

                UCBooking ucBooking = new UCBooking(booking.bookingID);
                ucBooking.lblHotelName.Content = $"{hotel.hotelName}";
                ucBooking.lblRoomType.Content = $"{room.roomType}";
                this.spBooking.Children.Add(ucBooking);
            }



        }
    }
}
