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
using Window_Final_Term_Projcet__WPF_.Login_and_Register;

namespace Window_Final_Term_Projcet__WPF_
{
    /// <summary>
    /// Interaction logic for PManager.xaml
    /// </summary>
    public partial class PManager : Page
    {
        public PManager()
        {
            InitializeComponent();
            this.mainContent.Content = new PLogin();
        }

        private void btnMoreRooms_Click(object sender, RoutedEventArgs e)
        {
            this.mainContent.Content = new PPartnership();
        }

        private void btnMyBusiness_Click(object sender, RoutedEventArgs e)
        {
            this.mainContent.Content = new PShowHotel();
        }

        private void btnMoreBusiness_Click(object sender, RoutedEventArgs e)
        {
            this.mainContent.Content = new PAddHotel();
        }
    }
}
