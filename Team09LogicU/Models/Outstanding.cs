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
    
    public partial class Outstanding
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Outstanding()
        {
            this.OutstandingItems = new HashSet<OutstandingItem>();
        }
    
        public int outstandingID { get; set; }
        public string deptID { get; set; }
        public string storeStaffID { get; set; }
        public System.DateTime disburseDate { get; set; }
        public string status { get; set; }
    
        public virtual StoreStaff StoreStaff { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutstandingItem> OutstandingItems { get; set; }
    }
}
