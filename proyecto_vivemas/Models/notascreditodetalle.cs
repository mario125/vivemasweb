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
    
    public partial class notascreditodetalle
    {
        public long notacreditodetalle_id { get; set; }
        public Nullable<long> notacreditodetalle_notadecredito_id { get; set; }
        public string notacreditodetalle_descripcion { get; set; }
        public string notacreditodetalle_unidadmedida_codigo { get; set; }
        public string notacreditodetalle_cantidad { get; set; }
        public string notacreditodetalle_codigo { get; set; }
        public string notacreditodetalle_tipoventasunat { get; set; }
        public string notacreditodetalle_tipoafectacion { get; set; }
        public Nullable<decimal> notacreditodetalle_subtotal { get; set; }
        public Nullable<decimal> notacreditodetalle_igv { get; set; }
        public Nullable<decimal> notacreditodetalle_total { get; set; }
        public Nullable<long> notacreditodetalle_usuariocreacion { get; set; }
        public Nullable<System.DateTime> notacreditodetalle_fechacreacion { get; set; }
        public Nullable<long> notacreditodetalle_usuariomodificacion { get; set; }
        public Nullable<System.DateTime> notaccrediodetalle_fechamodificacion { get; set; }
    
        public virtual notascredito notascredito { get; set; }
    }
}