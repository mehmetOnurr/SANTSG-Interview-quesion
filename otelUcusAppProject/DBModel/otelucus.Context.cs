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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class otelucusEntities1 : DbContext
    {
        public otelucusEntities1()
            : base("name=otelucusEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<amountflights> amountflights { get; set; }
        public virtual DbSet<amounthotel> amounthotel { get; set; }
        public virtual DbSet<flights> flights { get; set; }
        public virtual DbSet<hotels> hotels { get; set; }
        public virtual DbSet<locations> locations { get; set; }
        public virtual DbSet<reservation_customers> reservation_customers { get; set; }
        public virtual DbSet<reservation_services> reservation_services { get; set; }
        public virtual DbSet<reservations> reservations { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<customers> customers { get; set; }
    }
}
