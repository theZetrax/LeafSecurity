﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeafSecurity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LeafSecurityEntities : DbContext
    {
        public LeafSecurityEntities()
            : base("name=LeafSecurityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountInformation> AccountInformations { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<FingerprintTemplate> FingerprintTemplates { get; set; }
        public virtual DbSet<MinutiaeTemplatePath> MinutiaeTemplatePaths { get; set; }
        public virtual DbSet<UserInformation> UserInformations { get; set; }
    }
}
