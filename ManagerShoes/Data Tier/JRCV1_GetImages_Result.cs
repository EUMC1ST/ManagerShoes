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
    
    public partial class JRCV1_GetImages_Result
    {
        public int IdImage { get; set; }
        public int IdProduct { get; set; }
        public string Decription { get; set; }
        public byte[] Image { get; set; }
        public Nullable<System.DateTime> DateUpdate { get; set; }
        public string IsEnabled { get; set; }
    }
}
