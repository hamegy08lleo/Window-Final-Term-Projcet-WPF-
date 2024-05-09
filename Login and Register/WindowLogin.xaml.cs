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
using System.Windows.Shapes;
using Window_Final_Term_Projcet__WPF_.Objects;

namespace Window_Final_Term_Projcet__WPF_
{
    /// <summary>
    /// Interaction logic for WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        public int? userID; 
        public WindowLogin()
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            var customerID = customerDAO.validateLogin(txtUsername.Text, pabPassword.Password); 
            if (customerID != null) {
                this.userID = customerID;
                this.DialogResult = true; 
                this.Close();
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
                WindowRegister windowRegister = new WindowRegister();
                this.Close();
                windowRegister.ShowDialog();
        }
    }
}
