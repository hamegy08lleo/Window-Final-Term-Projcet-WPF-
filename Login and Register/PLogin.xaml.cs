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

namespace Window_Final_Term_Projcet__WPF_.Login_and_Register
{
        /// <summary>
        /// Interaction logic for PLogin.xaml
        /// </summary>
        public partial class PLogin : Page
        {
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

                private void btnLogin_Click(object sender, RoutedEventArgs e)
                {

                }

                private void btnRegister_Click(object sender, RoutedEventArgs e)
                {

                }

        }
}
