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
    
    public partial class DatosUnidadMedica
    {
        public int IdDatosUnidadMedica { get; set; }
        public int IdPersona { get; set; }
        public string ServicioIngreso { get; set; }
        public string TipPaciente { get; set; }
        public Nullable<System.DateTime> FechaIngresoUnidad { get; set; }
        public Nullable<bool> CasoIngresadoUCI { get; set; }
        public Nullable<bool> CasoIntubado { get; set; }
        public Nullable<bool> CasoDiagnostNeumoniaClinica { get; set; }
        public Nullable<bool> CasoDiagnostNeumoniaRadiológica { get; set; }
    
        public virtual DatosGenerales DatosGenerales { get; set; }
    }
}