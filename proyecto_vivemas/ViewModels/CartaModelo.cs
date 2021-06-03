using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto_vivemas.ViewModels
{
    public class CartaModelo
    {
        public string carta_fecha { get; set; }
        public string carta_cliente_nombres { get; set; }
        public string carta_cliente_direccion { get; set; }
        public string carta_lote { get; set; }
        public string carta_proyecto { get; set; }
        public string carta_fecha_creacion { get; set; }
        public string carta_penalidad { get; set; }
        public List<CartaDetalleModelo> carta_detalle { get; set; }
    }
    public class CartaDetalleModelo
    {
        public string carta_detalleMoneda { get; set; }
        public string carta_detalleLetra { get; set; }
        public string carta_detalleFecha { get; set; }
        public string carta_detalleCuota { get; set; }

        public static implicit operator List<object>(CartaDetalleModelo v)
        {
            throw new NotImplementedException();
        }
    }
}