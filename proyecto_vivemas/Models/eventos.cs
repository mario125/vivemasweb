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
    
    public partial class eventos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public eventos()
        {
            this.eventostipocontacto = new HashSet<eventostipocontacto>();
            this.transacciones = new HashSet<transacciones>();
        }
    
        public long evento_id { get; set; }
        public Nullable<long> evento_usuario_id { get; set; }
        public Nullable<long> evento_estadoevento_id { get; set; }
        public string evento_descripcion { get; set; }
        public System.DateTime evento_fechacreacion { get; set; }
        public System.DateTime evento_fechapropuesta { get; set; }
        public Nullable<bool> evento_estado { get; set; }
        public Nullable<decimal> evento_montopropuesto { get; set; }
        public Nullable<long> evento_contrato_id { get; set; }
    
        public virtual estadosevento estadosevento { get; set; }
        public virtual usuarios usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eventostipocontacto> eventostipocontacto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transacciones> transacciones { get; set; }
        public virtual contratos contratos { get; set; }
    }
}
