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
    
    public partial class Booking
    {
        public int bookingID { get; set; }
        public int roomID { get; set; }
        public int customerID { get; set; }
        public System.DateTime checkin { get; set; }
        public System.DateTime checkout { get; set; }
    
        public virtual Room Room { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
