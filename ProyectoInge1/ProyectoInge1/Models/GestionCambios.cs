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
    
    public partial class GestionCambios
    {
        public System.DateTime Fecha { get; set; }
        public string Razon { get; set; }
        public short idReqFunc { get; set; }
        public string realizadoPor { get; set; }
        public string nomProyecto { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual ReqFuncional ReqFuncional1 { get; set; }
    }
}
