using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
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
    /// Interaction logic for Pcustomer.xaml
    /// </summary>
    public partial class Pcustomer : Page
    {
        public Pcustomer()
        {
            InitializeComponent();
            dtpCheckin.DisplayDateStart = DateTime.Now;
            dtpCheckin.DisplayDateEnd = DateTime.Now.AddMonths(12);
            dtpCheckin.SelectedDate = DateTime.Today;
            dtpCheckin.SelectedDateChanged += dtpCheckin_SelectedDateChanged;
            cbbDuration.SelectionChanged += cbbDuration_SelectionChanged;
            load_checkout();
        }

        private void load_checkout()
        {
            int duration = cbbDuration.SelectedIndex + 1;
            DateTime date = dtpCheckin.SelectedDate.Value.AddDays(duration);          
            lblCheckout.Content = date.ToString();
        }

        private void dtpCheckin_SelectedDateChanged(object sender, EventArgs e)
        {
            load_checkout();

        }
        private void cbbDuration_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            load_checkout();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            CustomerSearch search = new CustomerSearch(UCInformation.cbbRoomType.Text, UCInformation.cbbCity.Text);
            RoomDAO roomDAO = mainWindow.RoomDAO; 
            mainWindow.MainContent.Navigate(new Presult(roomDAO.Search(search))); 
        }
    }
}
