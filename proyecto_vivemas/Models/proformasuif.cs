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
    
    public partial class proformasuif
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public proformasuif()
        {
            this.anexoscontratoproforma = new HashSet<anexoscontratoproforma>();
        }
    
        public long proformauif_id { get; set; }
        public Nullable<long> proformauif_estadouif_id { get; set; }
        public Nullable<long> proformauif_cliente_id { get; set; }
        public Nullable<long> proformauif_transaccion_id { get; set; }
        public Nullable<long> proformauif_tipodocumentoidentidad_id { get; set; }
        public Nullable<long> proformauif_estadocivil_id { get; set; }
        public Nullable<long> proformauif_lote_id { get; set; }
        public Nullable<long> proformauif_empresa_id { get; set; }
        public Nullable<long> proformauif_tiposociedad_id { get; set; }
        public Nullable<long> proformauif_idanterior { get; set; }
        public string proformauif_numeracion { get; set; }
        public string proformauif_tipodocumentoidentidad_descripcion { get; set; }
        public string proformauif_cliente_nrodocumento { get; set; }
        public string proformauif_cliente_razonsocial { get; set; }
        public string proformauif_estadocivil_descripcion { get; set; }
        public string proformauif_cliente_direccion { get; set; }
        public string proformauif_cliente_referenciadomicilio { get; set; }
        public string proformauif_cliente_nrocontacto { get; set; }
        public Nullable<System.DateTime> proformauif_fechanacimiento { get; set; }
        public string proformauif_nacionalidad { get; set; }
        public string proformauif_empresa_nombre { get; set; }
        public string proformauif_empresa_documento { get; set; }
        public string proformauif_empresa_direccion { get; set; }
        public Nullable<long> proformauif_representante_estadocivil_id { get; set; }
        public string proformauif_representante_nrodocumento { get; set; }
        public string proformauif_representante_razonsocial { get; set; }
        public string proformauif_representante_nrocontacto { get; set; }
        public string proformauif_representante_estadocivil_descripcion { get; set; }
        public Nullable<System.DateTime> proformauif_fechacreacion { get; set; }
        public Nullable<long> proformauif_usuariocreacion { get; set; }
        public Nullable<System.DateTime> proformauif_fechamodificacion { get; set; }
        public Nullable<long> proformauif_usuariomodificacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<anexoscontratoproforma> anexoscontratoproforma { get; set; }
        public virtual clientes clientes { get; set; }
        public virtual empresas empresas { get; set; }
        public virtual estadoscivil estadoscivil { get; set; }
        public virtual estadosuif estadosuif { get; set; }
        public virtual lotes lotes { get; set; }
        public virtual tiposdocumentoidentidad tiposdocumentoidentidad { get; set; }
        public virtual tipossociedad tipossociedad { get; set; }
        public virtual transacciones transacciones { get; set; }
    }
}
