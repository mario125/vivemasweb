//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyecto_vivemas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class bancos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bancos()
        {
            this.cuentasbanco = new HashSet<cuentasbanco>();
        }
    
        public long banco_id { get; set; }
        public string banco_idanterior { get; set; }
        public string banco_descripcion { get; set; }
        public string banco_descripcioncorta { get; set; }
        public Nullable<bool> banco_estado { get; set; }
        public Nullable<long> banco_usuariocreacion { get; set; }
        public Nullable<System.DateTime> banco_fechacreacion { get; set; }
        public Nullable<long> banco_usuariomodificacion { get; set; }
        public Nullable<System.DateTime> banco_fechamodificacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cuentasbanco> cuentasbanco { get; set; }
    }
}
