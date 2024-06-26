﻿using System;
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
using System.Xaml;

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
            mainContent.Content = new Pcustomer();
            // mainContent.Content = new Presult();
            //CustomerSearch search = new CustomerSearch("2 Single Bed", "Da Nang");
            //roomDAO.Search(search);
            //DebugWindow debugWindow = new DebugWindow();
            //debugWindow.debug(roomDAO.Search(search));
            //debugWindow.Show();

            //OwnerPost post = new OwnerPost("1 Single Bed", "Horizon Travel", "Ho Chi Minh city", 100, 10);
            //roomDAO.Add(post); 
        }
        private void lblLogo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainContent.Content = new Pcustomer();
            if (this.btnPartnership.Content.ToString() == "Customer")
            {
                this.btnPartnership.Content = "Partnership";
            }
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

        private void btnPartnership_Click(object sender, RoutedEventArgs e)
        {
            if (this.btnPartnership.Content.ToString() == "Partnership")
            {
                    mainContent.Content = new PManager();
                    this.btnPartnership.Content = "Customer";
            }
            else
            {
                    mainContent.Content = new Pcustomer();
                    this.btnPartnership.Content = "Partnership";
                    
            }
        }

        public Frame MainContent { get { return mainContent; } set { mainContent = value; } }


        private void btnBooking_Click(object sender, RoutedEventArgs e)
        {
                this.mainContent.Content = new PBooking();
        }
    }
}
