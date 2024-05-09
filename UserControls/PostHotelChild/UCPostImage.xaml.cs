using Microsoft.Win32;
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

namespace Window_Final_Term_Projcet__WPF_.UserControl.PostHotelChild
{
    /// <summary>
    /// Interaction logic for UCPostImage.xaml
    /// </summary>
    public partial class UCPostImage : System.Windows.Controls.UserControl
    {
        public List<String> imagesPath = new List<String>();
        public UCPostImage()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg;*.bmp;*.gif)|*.png;*.jpeg;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                Image image = new Image
                {
                    Width = 100,
                    Height = 100,
                    Source = new BitmapImage(new Uri(filePath)),
                };
                image.MouseLeftButtonDown += Image_MouseLeftButtonDown;
                imagesPath.Add(filePath);
                stpImageContainer.Children.Add(image);
            }

        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image image = sender as Image;
            if (e.ClickCount >= 2)
            {
                this.stpImageContainer.Children.Remove(image);
            }
        }
    }
}
