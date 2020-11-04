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
    using System.ComponentModel.DataAnnotations;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Pro_Pictures = new HashSet<Pro_Pictures>();
        }

        [Required(ErrorMessage = "Empty field")]
        public string Product_ID { get; set; }

        [Required(ErrorMessage = "Empty field")]
        public string Name { get; set; }
        public float Price { get; set; }
        public int Amount { get; set; }
        public int TypeID { get; set; }
        public string Store_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pro_Pictures> Pro_Pictures { get; set; }
        public virtual Store Store { get; set; }
        public virtual Product_Type Product_Type { get; set; }
    }
}
