//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NTTData.Com.BusinessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class PS_Orders
    {
        public decimal OrderID { get; set; }
        public string CustID { get; set; }
    
        public virtual PS_Customer PS_Customer { get; set; }
    }
}