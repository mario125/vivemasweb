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
    
    public partial class separaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public separaciones()
        {
            this.transaccionesseparacion = new HashSet<transaccionesseparacion>();
        }
    
        public long separacion_id { get; set; }
        public Nullable<long> separacion_cliente_id { get; set; }
        public Nullable<long> separacion_lote_id { get; set; }
        public Nullable<long> separacion_estadoseparacion_id { get; set; }
        public string separacion_numeroseparacion { get; set; }
        public Nullable<System.DateTime> separacion_fechainicio { get; set; }
        public Nullable<System.DateTime> separacion_fechafin { get; set; }
        public Nullable<decimal> separacion_monto { get; set; }
        public Nullable<System.DateTime> separacion_fechacreacion { get; set; }
        public Nullable<long> separacion_usuariocreacion { get; set; }
        public Nullable<System.DateTime> separacion_fechamodificacion { get; set; }
        public Nullable<long> separacion_usuariomodificacion { get; set; }
    
        public virtual clientes clientes { get; set; }
        public virtual estadosseparacion estadosseparacion { get; set; }
        public virtual lotes lotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transaccionesseparacion> transaccionesseparacion { get; set; }
    }
}
