﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiRest.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class venteproEntities : DbContext
    {
        public venteproEntities()
            : base("name=venteproEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORIE> CATEGORIE { get; set; }
        public virtual DbSet<CLIENT> CLIENT { get; set; }
        public virtual DbSet<COMMANDE> COMMANDE { get; set; }
        public virtual DbSet<FACTURE> FACTURE { get; set; }
        public virtual DbSet<LIGNE_COMMANDE> LIGNE_COMMANDE { get; set; }
        public virtual DbSet<MARQUE> MARQUE { get; set; }
        public virtual DbSet<PRODUIT> PRODUIT { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<db_error_list> db_error_list { get; set; }
        public virtual DbSet<db_LOB_output> db_LOB_output { get; set; }
        public virtual DbSet<db_storage> db_storage { get; set; }
        public virtual DbSet<t_dbms_sql_bind_variable> t_dbms_sql_bind_variable { get; set; }
        public virtual DbSet<t_dbms_sql_cursor> t_dbms_sql_cursor { get; set; }
        public virtual DbSet<t_dbms_sql_define_column> t_dbms_sql_define_column { get; set; }
        public virtual DbSet<t_dbms_sql_recordset> t_dbms_sql_recordset { get; set; }
    }
}
