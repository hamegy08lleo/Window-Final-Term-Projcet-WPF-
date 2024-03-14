using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Window_Final_Term_Projcet__WPF_
{
    internal class WatermarkGenerator
    {
        String watermark; 
        public void GenerateWatermark(TextBox txt, String watermark)
        {
            this.watermark = watermark;
            txt.GotFocus += GotFocus(txt); 
        } 
        private RoutedEventHandler GotFocus(TextBox txt)
        {
            if (txt.Text == watermark)
            {
                
            }
            throw new NotImplementedException();
        }

    }
}
