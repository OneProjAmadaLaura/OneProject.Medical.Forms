//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DatosGenerales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatosGenerales()
        {
            this.Antecedentes = new HashSet<Antecedentes>();
            this.Contactos = new HashSet<Contactos>();
            this.DatosClinicos = new HashSet<DatosClinicos>();
            this.DatosUnidadMedica = new HashSet<DatosUnidadMedica>();
            this.Evolucion = new HashSet<Evolucion>();
            this.InformacionFormato = new HashSet<InformacionFormato>();
            this.Laboratorio = new HashSet<Laboratorio>();
            this.Tratamiento = new HashSet<Tratamiento>();
            this.Viaje = new HashSet<Viaje>();
        }
    
        public int IdPersona { get; set; }
        public System.DateTime FechaIngresoUnidad { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Nombres { get; set; }
        public short NacimientoDía { get; set; }
        public short NacimientoMes { get; set; }
        public short NacimientoAnio { get; set; }
        public short Edad { get; set; }
        public string CURP { get; set; }
        public string Sexo { get; set; }
        public Nullable<bool> Embarazada { get; set; }
        public Nullable<short> MesesEmbarazo { get; set; }
        public Nullable<bool> EnPeriodoPuerperio { get; set; }
        public Nullable<short> DiasPuerperio { get; set; }
        public string Nacionalidad { get; set; }
        public string PaisOrigen { get; set; }
        public string NoExpedienteSeguridadSocial { get; set; }
        public string EntidadNacimiento { get; set; }
        public string EntidadDelegacionResidencia { get; set; }
        public string MunicipioResidencia { get; set; }
        public string Localidad { get; set; }
        public string Calle { get; set; }
        public string NoExterno { get; set; }
        public string NoInterno { get; set; }
        public string EntreCalles { get; set; }
        public string YCalle { get; set; }
        public string Colonia { get; set; }
        public string CP { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public bool SeReconoceIndigena { get; set; }
        public bool HablaAlgunaLenguaIndigena { get; set; }
        public string Ocupacion { get; set; }
        public bool EsMigrante { get; set; }
        public Nullable<bool> PagoRealizado { get; set; }
        public Nullable<System.DateTime> FechaPago { get; set; }
        public Nullable<System.DateTime> FechaImpresion { get; set; }
        public Nullable<System.DateTime> FechaPrueba { get; set; }
        public int IdUnidadNotificante { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Antecedentes> Antecedentes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contactos> Contactos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosClinicos> DatosClinicos { get; set; }
        public virtual DatosNotificante DatosNotificante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosUnidadMedica> DatosUnidadMedica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evolucion> Evolucion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InformacionFormato> InformacionFormato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Laboratorio> Laboratorio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tratamiento> Tratamiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viaje> Viaje { get; set; }
    }
}
