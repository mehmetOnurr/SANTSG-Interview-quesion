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
    
    public partial class reservations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public reservations()
        {
            this.reservation_customers = new HashSet<reservation_customers>();
            this.reservation_services = new HashSet<reservation_services>();
        }
    
        public int id { get; set; }
        public decimal price { get; set; }
        public string r_status { get; set; }
        public System.DateTime created_at { get; set; }
        public int created_by { get; set; }
        public System.DateTime begin_date { get; set; }
        public System.DateTime end_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservation_customers> reservation_customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservation_services> reservation_services { get; set; }
        public virtual users users { get; set; }
    }
}
