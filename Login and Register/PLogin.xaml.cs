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

namespace Window_Final_Term_Projcet__WPF_.Login_and_Register
{
    /// <summary>
    /// Interaction logic for PLogin.xaml
    /// </summary>
    public partial class PLogin : Page
    {
        public int? userID; 
        public PLogin()
        {
            InitializeComponent();
        }
        private void txtUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "Username or email")
            {
                txtUsername.Foreground = new SolidColorBrush(Colors.Black); 
                txtUsername.Text = "";
            }
        }

        private void txtUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Foreground = new SolidColorBrush(Colors.Gray); 
                txtUsername.Text = "Username or email"; 
            }
        }

        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                pabPassword.Password = "";
                txtPassword.Text = ""; 
                txtPassword.Visibility = Visibility.Collapsed;
                pabPassword.Focus(); 
            }
        }
        private void pabPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (pabPassword.Password == "")
            {
                txtPassword.Foreground = new SolidColorBrush(Colors.Gray);
                txtPassword.Visibility = Visibility.Visible; 
                txtPassword.Text = "Password";
            }
        }

        PManager GetPManager()
        {
            FrameworkElement frameworkElement = this; 
            while (frameworkElement.GetType() != new PManager().GetType())
            {
                frameworkElement = VisualTreeHelper.GetParent(frameworkElement) as FrameworkElement;
            }
            return frameworkElement as PManager;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            OwnerDAO ownerDAO = new OwnerDAO();
            var ownerID = ownerDAO.validateLogin(txtUsername.Text, pabPassword.Password); 
            if (ownerID != null) {
                this.userID = ownerID.Value;
                MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
                mainWindow.ownerID = ownerID;
                PManager pManager = GetPManager();
                pManager.ownerID = ownerID.Value; 
                pManager.mainContent.Navigate(new PShowHotel(ownerID.Value));
                pManager.btnMoreBusiness.Visibility = Visibility.Visible;
                pManager.btnMyBusiness.Visibility = Visibility.Visible;
                pManager.btnMoreRooms.Visibility = Visibility.Visible;
            }
        }

                private void btnRegister_Click(object sender, RoutedEventArgs e)
                {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.mainContent.Content = new PRegister();
                }

    }
}
