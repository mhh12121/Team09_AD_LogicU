//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team09LogicU.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdjustmentVoucherItem
    {
        public int adjVItemID { get; set; }
        public int adjVID { get; set; }
        public string itemID { get; set; }
        public int quantity { get; set; }
    
        public virtual AdjustmentVoucher AdjustmentVoucher { get; set; }
        public virtual Item Item { get; set; }
    }
}
