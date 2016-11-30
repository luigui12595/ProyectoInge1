//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoInge1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Solicitud
    {
        public System.DateTime fecha { get; set; }
        public string estado { get; set; }
        public string razon { get; set; }
        public string realizadoPor { get; set; }
        public string aprobadoPor { get; set; }
        public short versionRF { get; set; }
        public int idReqFunc { get; set; }
        public string nomProyecto { get; set; }
        public string nombreRF { get; set; }
        public Nullable<byte> sprintRF { get; set; }
        public Nullable<byte> moduloRF { get; set; }
        public Nullable<System.DateTime> fechaInicialRF { get; set; }
        public Nullable<System.DateTime> fechaFinalRF { get; set; }
        public string observacionesRF { get; set; }
        public string descripcionRF { get; set; }
        public Nullable<short> esfuerzoRF { get; set; }
        public Nullable<short> prioridadRF { get; set; }
        public byte[] imagenRF { get; set; }
        public string responsable1RF { get; set; }
        public string responsable2RF { get; set; }
    
        public virtual HistVersiones HistVersiones { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        public virtual Usuario Usuario2 { get; set; }

        public string razonPreview { get { return razon.Length > 10 ? razon.Substring(0, 10) + "..." : razon; } }
    }
}
