﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TEC_QA_CRMEntities : DbContext
    {
        public TEC_QA_CRMEntities()
            : base("name=TEC_QA_CRMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CorporateRepresentative> CorporateRepresentatives { get; set; }
        public virtual DbSet<Corporation> Corporations { get; set; }
        public virtual DbSet<CorporationsPhoneNumber> CorporationsPhoneNumbers { get; set; }
        public virtual DbSet<ErrorReport> ErrorReports { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<PersonsPhoneNumber> PersonsPhoneNumbers { get; set; }
        public virtual DbSet<ReviewPetition> ReviewPetitions { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SalesPetition> SalesPetitions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersSession> UsersSessions { get; set; }
        public virtual DbSet<Contact_View> Contact_View { get; set; }
    }
}
