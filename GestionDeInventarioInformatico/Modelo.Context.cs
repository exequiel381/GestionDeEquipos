﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionDeInventarioInformatico
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gestionDBEntities : DbContext
    {
        public gestionDBEntities()
            : base("name=gestionDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cambioTipos> cambioTipos { get; set; }
        public virtual DbSet<departamentos> departamentos { get; set; }
        public virtual DbSet<equipos> equipos { get; set; }
        public virtual DbSet<historialCambios> historialCambios { get; set; }
        public virtual DbSet<marcas> marcas { get; set; }
        public virtual DbSet<perifericos> perifericos { get; set; }
        public virtual DbSet<proveedores> proveedores { get; set; }
        public virtual DbSet<ramtipo> ramtipo { get; set; }
        public virtual DbSet<tipoEquipos> tipoEquipos { get; set; }
        public virtual DbSet<tipoPerifericos> tipoPerifericos { get; set; }
        public virtual DbSet<unidadAlmacenamiento> unidadAlmacenamiento { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    }
}
