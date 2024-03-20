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
            // mainContent.Content = new Pcustomer();
            mainContent.Content = new Presult();
        }

        private void lblLogo_MouseDown(object sender, MouseButtonEventArgs e)
        {
           mainContent.Content = null;
            mainContent.Content = new Pcustomer();
            MessageBox.Show("hello");
        }
        private void imgLogo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lblLogo_MouseDown(sender, e);
        }
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            WindowLogin windowLogin = new WindowLogin();
            windowLogin.ShowDialog();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            WindowLogin windowLogin = new WindowLogin();
            windowLogin.ShowDialog();
        }
    }
}
