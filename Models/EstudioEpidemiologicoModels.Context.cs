﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OneProject.Medical.Forms.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EstudioEpidemiologicoEntities : DbContext
    {
        public EstudioEpidemiologicoEntities()
            : base("name=EstudioEpidemiologicoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Antecedentes> Antecedentes { get; set; }
        public virtual DbSet<Contactos> Contactos { get; set; }
        public virtual DbSet<DatosClinicos> DatosClinicos { get; set; }
        public virtual DbSet<DatosGenerales> DatosGenerales { get; set; }
        public virtual DbSet<DatosNotificante> DatosNotificante { get; set; }
        public virtual DbSet<DatosUnidadMedica> DatosUnidadMedica { get; set; }
        public virtual DbSet<Evolucion> Evolucion { get; set; }
        public virtual DbSet<InformacionFormato> InformacionFormato { get; set; }
        public virtual DbSet<Laboratorio> Laboratorio { get; set; }
        public virtual DbSet<Tratamiento> Tratamiento { get; set; }
        public virtual DbSet<Viaje> Viaje { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
