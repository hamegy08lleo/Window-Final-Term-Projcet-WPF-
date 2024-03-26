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
        public Presult(DataTable result) 
        {
            InitializeComponent();
            foreach (DataRow row in result.Rows)
            {
                UCHotelResult ucResult = new UCHotelResult();
                ucResult.lblHotelName.Content = row[3].ToString();
                ucResult.lblAddress.Content = row[1].ToString();
                ucResult.lblPrice.Content = row[4].ToString() + "$";
                this.spResult.Children.Add(ucResult);

                string rating = "";
                for (int i = 0; i < int.Parse(row[5].ToString()) ; i++)
                {
                    rating += "⭐";
                }
                ucResult.lblRating.Content = rating;
            }
        }

        private void spResult_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
