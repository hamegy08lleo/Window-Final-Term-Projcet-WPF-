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

namespace Window_Final_Term_Projcet__WPF_
{
    /// <summary>
    /// Interaction logic for UCBooking.xaml
    /// </summary>
    public partial class UCBooking : UserControl
    {

        private string bookingID; 
        public UCBooking(string bookingID)
        {
            InitializeComponent();
            this.bookingID = bookingID;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            BookingDAO bookingDAO = new BookingDAO();
            bookingDAO.cancelBooking(bookingID);
            FrameworkElement frameworkElement = this as FrameworkElement;
            while (frameworkElement.GetType().ToString() != new PBooking().GetType().ToString())
            {
                frameworkElement = VisualTreeHelper.GetParent(frameworkElement) as FrameworkElement;
            }
            PBooking pBooking = frameworkElement as PBooking;
            pBooking.NavigationService.Navigate(new PBooking()); 
        }
    }
}
