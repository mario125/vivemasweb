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
    
    public partial class cuentasbanco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cuentasbanco()
        {
            this.transacciones = new HashSet<transacciones>();
        }
    
        public long cuentabanco_id { get; set; }
        public Nullable<long> cuentabanco_banco_id { get; set; }
        public Nullable<long> cuentabanco_moneda_id { get; set; }
        public Nullable<long> cuentabanco_idanterior { get; set; }
        public string cuentabanco_cuenta { get; set; }
        public Nullable<bool> cuentabanco_estado { get; set; }
        public Nullable<long> cuentabanco_usuariocreacion { get; set; }
        public Nullable<System.DateTime> cuentabanco_fechacreacion { get; set; }
        public Nullable<long> cuentabanco_usuariomodificacion { get; set; }
        public Nullable<System.DateTime> cuentabanco_fechamodificacion { get; set; }
    
        public virtual bancos bancos { get; set; }
        public virtual monedas monedas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transacciones> transacciones { get; set; }
    }
}
