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
    
    public partial class Antecedentes
    {
        public int IdAntecedentes { get; set; }
        public int IdPersona { get; set; }
        public bool ViajoChina14dPrevInicioSintomas { get; set; }
        public bool ResidenteChina { get; set; }
        public Nullable<System.DateTime> FechaViajeChina { get; set; }
        public string AerolineaVueloLlegadaMexico { get; set; }
        public Nullable<System.DateTime> FechaLlegadaMexico { get; set; }
        public string ContactoPersonaSintomasRespiratorios { get; set; }
        public Nullable<short> LugarContactoPersonas { get; set; }
        public bool ContactoAnimales { get; set; }
        public string CualAnimal { get; set; }
        public Nullable<short> TipoContactoAnimal { get; set; }
        public bool VisitoMercadoVentaAnimales { get; set; }
        public Nullable<System.DateTime> FechaVisitaMercado { get; set; }
        public bool Ult14dContacCercanoPersSospCoV { get; set; }
        public bool Ult14dContacCercanoPersCorfiLabCoV { get; set; }
        public bool ContacPersViajChina14dPrevIniSintomas { get; set; }
        public string LugarMercadoVentaAnimales { get; set; }
    
        public virtual DatosGenerales DatosGenerales { get; set; }
    }
}
