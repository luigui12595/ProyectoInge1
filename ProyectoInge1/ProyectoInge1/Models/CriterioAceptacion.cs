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
    
    public partial class CriterioAceptacion
    {
        public int idReqFunc { get; set; }
        public string nomProyecto { get; set; }
        public string criterio { get; set; }
    
        public virtual ReqFuncional ReqFuncional { get; set; }
    }
}
