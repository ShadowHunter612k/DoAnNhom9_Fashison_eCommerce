//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Items
    {
        public string Order_ID { get; set; }
        public int Item_ID { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<double> discount { get; set; }
        public Nullable<double> total { get; set; }
        public string status { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
