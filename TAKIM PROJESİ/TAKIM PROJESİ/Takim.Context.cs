﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAKIM_PROJESİ
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TakimContainer : DbContext
    {
        public TakimContainer()
            : base("name=TakimContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Oyuncu> OyuncuSet { get; set; }
        public virtual DbSet<Takim> TakimSet { get; set; }
        public virtual DbSet<Ulke> UlkeSet { get; set; }
        public virtual DbSet<Mevki> MevkiSet { get; set; }
        public virtual DbSet<Kullanici> KullaniciSet { get; set; }
    }
}
