﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<UserXTraining> UserXTrainings { get; set; }
    
        public virtual ObjectResult<getTrainings_Result> getTrainings(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getTrainings_Result>("getTrainings", userIDParameter);
        }
    
        public virtual ObjectResult<getRelationatedProducts_Result> getRelationatedProducts(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getRelationatedProducts_Result>("getRelationatedProducts", userIDParameter);
        }
    }
}
