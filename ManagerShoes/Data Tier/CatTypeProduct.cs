//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Tier
{
    using System;
    using System.Collections.Generic;
    
    public partial class CatTypeProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatTypeProduct()
        {
            this.CatSizes = new HashSet<CatSize>();
            this.CatTypeDetails = new HashSet<CatTypeDetail>();
            this.Products = new HashSet<Product>();
        }
    
        public int IdType { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public System.DateTime DateUpdate { get; set; }
        public bool IsEnabled { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatSize> CatSizes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatTypeDetail> CatTypeDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
