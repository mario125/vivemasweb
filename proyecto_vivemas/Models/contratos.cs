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
    
    public partial class contratos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contratos()
        {
            this.anexoscontratocotizacion = new HashSet<anexoscontratocotizacion>();
            this.anexoscontratoproforma = new HashSet<anexoscontratoproforma>();
            this.eventos = new HashSet<eventos>();
        }
    
        public long contrato_id { get; set; }
        public Nullable<long> contrato_estadocontrato_id { get; set; }
        public string contrato_numeracion { get; set; }
        public Nullable<System.DateTime> contrato_fechacreacion { get; set; }
        public Nullable<long> contrato_usuariocreacion { get; set; }
        public Nullable<System.DateTime> contrato_fechamodificacion { get; set; }
        public Nullable<long> contrato_usuariomodificacion { get; set; }
        public Nullable<long> contrato_idanterior { get; set; }
        public Nullable<System.DateTime> contrato_fecharesolucion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<anexoscontratocotizacion> anexoscontratocotizacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<anexoscontratoproforma> anexoscontratoproforma { get; set; }
        public virtual estadoscontrato estadoscontrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eventos> eventos { get; set; }
    }
}
