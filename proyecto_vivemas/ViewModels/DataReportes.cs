using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto_vivemas.ViewModels
{
    public class DataReportes
    {
        public long? idProyecto { get; set; }
        public long idTipoTransaccion { get; set; }
        public long? idContrato { get; set; }
        public long idMetodoPago { get; set; }
        public long idBancoDestino { get; set; }
        public long idNroCuentaBancoDestino { get; set; }
        public string fechaDesde { get; set; }
        public string fechaHasta { get; set; }
    }

    public class DataReportesEventoDetalle
    {
        public string codigo { get; set; }
      
    }

    public class DataReportePagos
    {
        public string cuota_numeracion { get; set; }
        public string cuota_fechavencimiento { get; set; }
        public decimal? cuota_monto { get; set; }
        public decimal? transaccion_monto { get; set; }
        public decimal? pago_montodescuento { get; set; }
        public string fecha_pago { get; set; }
        public string cuota_estado { get; set; }
    }
}