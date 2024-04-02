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

namespace Window_Final_Term_Projcet__WPF_
{
        /// <summary>
        /// Interaction logic for WNotification.xaml
        /// </summary>
        public partial class WNotification : Window
        {
                protected override void OnSourceInitialized(EventArgs e)
                {
                        base.OnSourceInitialized(e);

                        // Get the position and size of the parent window
                        Window parentWindow = this.Owner;
                        Rect parentRect = new Rect(parentWindow.Left, parentWindow.Top, parentWindow.Width, parentWindow.Height);

                        // Calculate the center position of the parent window
                        double centerX = parentRect.Left + parentRect.Width / 2;
                        double centerY = parentRect.Top + parentRect.Height / 2;

                        // Set the position of the child window
                        this.Left = centerX - this.Width / 2;
                        this.Top = centerY - this.Height / 2;
                }
                public WNotification()
                {
                        InitializeComponent();
                }
                public void Notification(string notiString) => this.lblNotification.Content = notiString;
        }
}
