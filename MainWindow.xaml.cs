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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void lblLogo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Owner = this;
            //mainWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            //mainWindow.Left = 100; // set the left position
            //mainWindow.Top = 100; // set the top position
            //this.Hide();
            //mainWindow.ShowDialog();
            mainContent.Content = null;
            mainContent.Content = new CustomerPage();
        }
        private void imgLogo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lblLogo_MouseDown(sender, e);
        }
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBooking_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPartnership_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
