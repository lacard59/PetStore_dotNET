//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchase_Detail
    {
        public decimal PurchaseDetailID { get; set; }
        public Nullable<decimal> OrderID { get; set; }
        public Nullable<decimal> ItemID { get; set; }
        public Nullable<decimal> ProdID { get; set; }
        public Nullable<decimal> CategID { get; set; }
        public Nullable<decimal> Quantity { get; set; }
    
        public virtual Category_Products Category_Products { get; set; }
        public virtual Product_Line_Items Product_Line_Items { get; set; }
        public virtual PS_Categories PS_Categories { get; set; }
        public virtual PS_Orders PS_Orders { get; set; }
    }
}