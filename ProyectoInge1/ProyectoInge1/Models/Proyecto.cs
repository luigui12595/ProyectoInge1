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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Proyecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proyecto()
        {
            this.ReqFuncional = new HashSet<ReqFuncional>();
            this.Usuario1 = new HashSet<Usuario>();
        }

        [DisplayName("Nombre:")]
        public string nombre { get; set; }

        [DisplayName("Descripci�n:")]
        public string descripcion { get; set; }

        [Display(Name = "Fecha de Inicio:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> fechaInicio { get; set; }

        
        [Display(Name = "Fecha Final:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> fechaFinal { get; set; }

        [DisplayName("L�der:")]
        public string lider { get; set; }

        [DisplayName("Estado:")]
        public string estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReqFuncional> ReqFuncional { get; set; }

        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [DisplayName("Desarrolladores:")]
        public virtual ICollection<Usuario> Usuario1 { get; set; }
    }
}
