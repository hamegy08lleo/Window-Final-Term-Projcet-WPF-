using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Presult.xaml
    /// </summary>
    public partial class Presult : Page
    {
        public Presult()
        {
            InitializeComponent();
        }
        public Presult(DataTable result, string roomType)
        {
            InitializeComponent();
            foreach (DataRow row in result.Rows)
            {
                UCHotelResult ucResult = new UCHotelResult(row[0].ToString(), roomType);
                ucResult.lblHotelName.Content = row[1].ToString();
                ucResult.lblAddress.Content = row[2].ToString();
                ucResult.lblPrice.Content = row[3].ToString() + "$";

                string rating = "";
                for (int i = 0; i < float.Parse(row[4].ToString()); i++)
                {
                    rating += "⭐";
                }
                ucResult.lblRating.Content = rating;
                ucResult.btnSelectRoom.Click += ucResult.btnSelectRoom_Click;
                this.spResult.Children.Add(ucResult);
            }
            StackPanel nullHotel = new StackPanel();
            Image noHotelImage = new Image();
            noHotelImage.Source = new BitmapImage(new Uri("/BackgroundIMG/noHotel.png", UriKind.Relative));
            noHotelImage.Width = 141;
            noHotelImage.HorizontalAlignment = HorizontalAlignment.Center;
            nullHotel.Children.Add(noHotelImage);

            Label errorLabel1 = new Label();
            errorLabel1.Content = "Hotel Not Available";
            errorLabel1.FontSize = 24;
            errorLabel1.HorizontalAlignment = HorizontalAlignment.Center;
            nullHotel.Children.Add(errorLabel1);

            Label errorLabel2 = new Label();
            errorLabel2.Content = "Sorry, no hotel matches your preference. Please change your search.";
            errorLabel2.FontSize = 24;
            errorLabel2.HorizontalAlignment = HorizontalAlignment.Center;
            nullHotel.Children.Add(errorLabel2);

            int count = this.spResult.Children.Count;
            if (count == 0)
            {
                this.spResult.Children.Add(nullHotel);
            }
        }

        private void spResult_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
