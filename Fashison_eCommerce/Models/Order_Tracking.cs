//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fashison_eCommerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Tracking
    {
        public int Track_ID { get; set; }
        public string Order_ID { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> Status { get; set; }
        public string Description { get; set; }
        public Nullable<int> Shipper_ID { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual User User { get; set; }
    }
}