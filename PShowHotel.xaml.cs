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
    /// Interaction logic for PShowHotel.xaml
    /// </summary>
    public partial class PShowHotel : Page
    {
        public PShowHotel()
        {
            InitializeComponent();
            HotelDAO hotelDAO = new HotelDAO();
            DataTable dt = hotelDAO.listHotelName();
            foreach (DataRow row in dt.Rows)
            {
                UCHotel ucHotel = new UCHotel();
                ucHotel.lblHotelName.Content = row[0].ToString(); 
                this.spHotel.Children.Add(ucHotel); 
            }
        }
    }
}
