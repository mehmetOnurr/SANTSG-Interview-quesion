//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace otelUcusAppProject.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class reservation_customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public reservation_customers()
        {
            this.customers = new HashSet<customers>();
        }
    
        public int customer_id { get; set; }
        public int reservation_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<customers> customers { get; set; }
        public virtual reservations reservations { get; set; }
    }
}
