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
    
    public partial class sp_cargarCuotas_Result
    {
        public long cuota_id { get; set; }
        public string contrato_numeracion { get; set; }
        public string cuota_numeracion { get; set; }
        public string cuota_fechavencimiento { get; set; }
        public Nullable<decimal> cuota_monto { get; set; }
        public Nullable<decimal> cuota_montopagado { get; set; }
        public string proyecto_nombrecorto { get; set; }
        public string lote_manzana { get; set; }
        public string lote_numero { get; set; }
    }
}
