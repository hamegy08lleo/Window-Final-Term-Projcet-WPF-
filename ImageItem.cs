//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Window_Final_Term_Projcet__WPF_
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImageItem
    {
        public int imageID { get; set; }
        public string imagePath { get; set; }
        public int hotelID { get; set; }
        public Nullable<int> roomID { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        public virtual Room Room { get; set; }
    }
}