﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModuloSeguridad.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDSEGURIDADEntities : DbContext
    {
        public BDSEGURIDADEntities()
            : base("name=BDSEGURIDADEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PERM_ROL> PERM_ROL { get; set; }
        public virtual DbSet<PERMISOS> PERMISOS { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<USR_PERM> USR_PERM { get; set; }
        public virtual DbSet<USR_ROL> USR_ROL { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
    }
}
