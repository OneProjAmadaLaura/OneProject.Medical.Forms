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
    
    public partial class Viaje
    {
        public int IdViaje { get; set; }
        public int IdPersona { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public System.DateTime FechaLlegada { get; set; }
        public System.DateTime FechaSalida { get; set; }
        public string AerolineaVuelo { get; set; }
    
        public virtual DatosGenerales DatosGenerales { get; set; }
    }
}
