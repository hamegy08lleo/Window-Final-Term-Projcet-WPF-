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
    /// Interaction logic for WindowRegister.xaml
    /// </summary>
    public partial class WindowRegister : Window
    {
        public WindowRegister()
        {
            InitializeComponent();
        }


        private void txtUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "Username")
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
                txtUsername.Text = "Username";
            }
        }
        private void txtName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Foreground = new SolidColorBrush(Colors.Black);
                txtName.Text = "";
            }
        }

        private void txtName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Foreground = new SolidColorBrush(Colors.Gray);
                txtName.Text = "Name";
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
            WindowLogin windowLogin = new WindowLogin();
            this.Close();
            windowLogin.ShowDialog();
        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            var username = txtUsername.Text;
            var password = pabPassword.Password;
            var email = txtEmail.Text;
            var phoneNumber = txtPhone.Text;
            if (customerDAO.validateRegister(username, email, phoneNumber))
            {
                var customerID = customerDAO.register(username, password, email, phoneNumber);
                MessageBox.Show(customerID.ToString()); 
            }; 

        }


        private void txtEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Foreground = new SolidColorBrush(Colors.Black);
                txtEmail.Text = "";
            }
        }

        private void txtEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Foreground = new SolidColorBrush(Colors.Gray);
                txtEmail.Text = "Email";
            }
        }
        private void txtPhone_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPhone.Text == "Phone number")
            {
                txtPhone.Foreground = new SolidColorBrush(Colors.Black);
                txtPhone.Text = "";
            }
        }

        private void txtPhone_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                txtPhone.Foreground = new SolidColorBrush(Colors.Gray);
                txtPhone.Text = "Phone number";
            }
        }
    }
}
